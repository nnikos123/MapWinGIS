// UndoList.h : Declaration of the CUndoList
#pragma once
#include "TableRow.h"

#if defined(_WIN32_WCE) && !defined(_CE_DCOM) && !defined(_CE_ALLOW_SINGLE_THREADED_OBJECTS_IN_MTA)
#error "Single-threaded COM objects are not properly supported on Windows CE platform, such as the Windows Mobile platforms that do not include full DCOM support. Define _CE_ALLOW_SINGLE_THREADED_OBJECTS_IN_MTA to force ATL to support creating single-thread COM object's and allow use of it's single-threaded COM object implementations. The threading model in your rgs file was set to 'Free' as that is the only threading model supported in non DCOM Windows CE platforms."
#endif

using namespace ATL;

// CUndoList
class ATL_NO_VTABLE CUndoList :
	public CComObjectRootEx<CComSingleThreadModel>,
	public CComCoClass<CUndoList, &CLSID_UndoList>,
	public IDispatchImpl<IUndoList, &IID_IUndoList, &LIBID_MapWinGIS, /*wMajor =*/ VERSION_MAJOR, /*wMinor =*/ VERSION_MINOR>
{
public:
	CUndoList()
	{
		_shapefile = NULL;
		_key = A2BSTR("");
		_lastErrorCode = tkNO_ERROR;
		_position = -1;
		_batchId = EMPTY_BATCH_ID;
	}
	~CUndoList()
	{
		Clear();
	}

	DECLARE_REGISTRY_RESOURCEID(IDR_UNDOLIST)

	BEGIN_COM_MAP(CUndoList)
		COM_INTERFACE_ENTRY(IUndoList)
		COM_INTERFACE_ENTRY(IDispatch)
	END_COM_MAP()

	DECLARE_PROTECT_FINAL_CONSTRUCT()

	HRESULT FinalConstruct()
	{
		return S_OK;
	}

	void FinalRelease()
	{
	}
	
public:
	STDMETHOD(Undo)(VARIANT_BOOL* retVal);
	STDMETHOD(Redo)(VARIANT_BOOL* retVal);
	STDMETHOD(get_UndoCount)(LONG* pVal);
	STDMETHOD(get_RedoCount)(LONG* pVal);
	STDMETHOD(get_TotalLength)(LONG* pVal);
	STDMETHOD(BeginBatch)(VARIANT_BOOL* retVal);
	STDMETHOD(EndBatch)(LONG* retVal);
	STDMETHOD(Add)(tkUndoOperation operation, LONG ShapeIndex, VARIANT_BOOL* retVal);
	STDMETHOD(get_ErrorMsg)(/*[in]*/ long ErrorCode, /*[out, retval]*/ BSTR *pVal);
	STDMETHOD(get_LastErrorCode)(/*[out, retval]*/ long *pVal);
	STDMETHOD(get_Key)(/*[out, retval]*/ BSTR *pVal);
	STDMETHOD(put_Key)(/*[in]*/ BSTR newVal);
	STDMETHOD(Clear)();
	STDMETHOD(AddSubOperation)(tkUndoOperation operation, LONG ShapeIndex, IShape* shapeData, VARIANT_BOOL* retVal);
	STDMETHOD(GetLastId)(LONG* retVal);
public:
	void Init(IShapefile* sf){
		_shapefile = sf;	// no AddRef since the life span of this 2 objects is the same
	}

private:
	struct UndoListItem
	{
		int BatchId;          // globally unique across all lists but same within batch
		long ShapeIndex;
		tkUndoOperation Operation;
		IShape* Shape;
		TableRow* Row;
		bool Undone;

		UndoListItem(int id, int shapeIndex, tkUndoOperation operation)
			: Undone(false), Shape(NULL), Row(NULL), BatchId(id), ShapeIndex(shapeIndex), Operation(operation)
		{
			
		}

		~UndoListItem() {
			if (Shape) Shape->Release();
			if (Row) delete Row;
		}
	};

	static int g_UniqueId;
	static const int EMPTY_BATCH_ID;

	long _lastErrorCode;
	BSTR _key;
	IShapefile* _shapefile;
	vector<UndoListItem*> _list;
	
	int _batchId;
	int _position;

	bool UndoSingleItem(UndoListItem* item, ITable* tbl);
	void CopyShapeState(int shapeIndex, UndoListItem* item);
	void TrimList();
	void ErrorMessage(long ErrorCode);
	bool CheckState();
	int NextId() { 
		return ++g_UniqueId;
	}
	bool CheckShapeIndex(LONG shapeIndex);
public:
	
};
OBJECT_ENTRY_AUTO(__uuidof(UndoList), CUndoList)