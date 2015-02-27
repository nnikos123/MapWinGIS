﻿using System;
using MapWinGIS;

#if nsp
namespace MapWinGIS
{
#endif

    /// <summary>
    /// Holds global settings for MapWinGIS. Allows to retrieve GDAL errors.
    /// </summary>
    /// <remarks>All the properties of this class are defined as global variables and therefore changes in any instance of this 
    /// class will affect all the instances of MapWinGIS control hosted by the application.\n\n
    /// The major part of properties require advanced understanding of MapWinGIS functioning therefore it's not recommended
    /// to change them without a good reason.\n\n
    /// Sometimes properties can be added to this class to provide a switch for testing new functions.
    /// Such properties may be removed afterwards (GlobalSettings.ShapefileFastUnion for example).</remarks>
    /// \new48 Added in version 4.8
    #if nsp
        #if upd
            public class GlobalSettings : MapWinGIS.IGlobalSettings
        #else        
            public class IGlobalSettings
        #endif
    #else
        public class GlobalSettings
    #endif
    {
        /// <summary>
        /// Gets a sets a value which defines the multiplication coefficient for data in decimal degrees.
        /// </summary>
        /// <remarks>The value is used for Clipper library due to the lack of built-in scaling in it. The default value is 10000.0.</remarks>
        public double ClipperGcsMultiplicationFactor
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets a value which is used to weed out long narrow "splintered" polygons generated by geoprocessing routines.
        /// </summary>
        /// <remarks>Polygons with area to perimeter ratio less than this values won't be passed to the output.
        /// The default value is 0.0001.
        /// </remarks>
        public double MinAreaToPerimeterRatio
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets the minimal area of polygon which will be passed to the output by geoprocessing routines.
        /// </summary>
        /// <remarks>When the data is defined in decimal degrees, this value will be divided into squared conversion factor 
        /// between decimal degrees and meters (roughly 110000 per degree).</remarks>
        /// <remarks>The default value is 1.0.</remarks>
        public double MinPolygonArea
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets the value which indicates whether all the new instances of Shapefile class will be initialized with the fast mode turned on.
        /// </summary>
        /// <remarks>The default value is false.</remarks>
        /// \see Shapefile.FastMode
        public bool ShapefileFastMode
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Extracts the last error message reported by GDAL library.
        /// </summary>
        public string GdalLastErrorMsg
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets a subtype of the last error reported by GDAL library.
        /// </summary>
        public tkGdalError GdalLastErrorNo
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets a type of the last error reported by GDAL library.
        /// </summary>
        public tkGdalErrorType GdalLastErrorType
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets last error reported by GDAL reprojection routine.
        /// </summary>
        /// <remarks>Can be used to find out the source of failure of Shapefile.Reproject and Shapefile.ReprojectInPlace functions.</remarks>
        public string GdalReprojectionErrorMsg
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets GDI+ compositing quality for label drawing which will be used for all newly added layers.
        /// </summary>
        /// <remarks>The default value is HighQuality.</remarks>
        public tkCompositingQuality LabelsCompositingQuality
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets GDI+ smoothing mode for label drawing which will be used for all newly added layers.
        /// </summary>
        /// <remarks>The default value is HighQualityMode.</remarks>
        public tkSmoothingMode LabelsSmoothingMode
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Clears information about last GDAL error.
        /// </summary>
        /// <remarks>Affects GdalLastErrorMsg, GdalLastErrorNo, GdalLastErrorType, GdalReprojectionErrorMsg properties.</remarks>
        public void ResetGdalError()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets or sets a value which affects the speed of Shapefile.Union operation.
        /// </summary>
        /// <remarks>The default value is true.</remarks>
        public bool ShapefileFastUnion
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets format to be used for displaying grid datasources using image proxy.
        /// </summary>
        /// <remarks>Methods like Grid.HasImageProxy or Grid.RemoveImageProxy will only 
        /// take into account the format chosen in these property.</remarks>
        /// \new490 Added in version 4.9.0
        public tkGridProxyFormat GridProxyFormat
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets preferred display mode for grid datasources. 
        /// </summary>
        /// <remarks>This property will be used in AxMap.AddLayer and Grid.OpenAsImage methods 
        /// if Grid.PreferedDisplayMode is set to gpmAuto.</remarks>
        /// \new490 Added in version 4.9.0
        public tkGridProxyMode GridProxyMode
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Sets collision mode for all instances of Labels class (which represent labels for either shapefiles or images).
        /// </summary>
        /// \new490 Added in version 4.9.0
        public tkCollisionMode LabelsCollisionMode
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets maximum allowable size in MB for a grid datasource to be opened without proxy creation.
        /// </summary>
        /// <remarks> For grids with size exceeding the value of this property, proxy image will be created when GridProxyMode
        /// is set to gpmAuto or gpmFavourNoProxy; for gpmNoProxy Grid.CanDisplayWithoutProxy will return false 
        /// and Grid.OpenAsImage will fail. Grids of smaller size will be rendered directly for all the modes but gpmUseProxy if
        /// datasources format allows it (see Grid.CanDisplayWithoutProxy).
        /// Default value is 20.0 MB. Zero of negative values set no limitation. 
        /// Direct rendering of grid datasources is computationally expensive process 
        /// therefore for large datasources rendering may become too slow.</remarks>
        /// \new491 Added in version 4.9.1
        public double MaxDirectGridSizeMb
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets the maximum allowable number of unique values in grid color scheme. 
        /// </summary>
        /// <remarks>Affects Grid.GeneratedColorScheme when generation method is set to  gsgUniqueValues or gsgUniqueValuesOrGradient.</remarks>
        /// \new491 Added in version 4.9.1
        public int MaxUniqueValuesCountForGridScheme
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets a value indicating whether a map will zoom automatically to the first layer added with AxMap.AddLayer.
        /// </summary>
        /// \new491 Added in version 4.9.1
        public bool ZoomToFirstLayer
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets the localized version for a specified string used in GUI.
        /// </summary>
        /// <param name="str">String to get localized version for.</param>
        /// <returns>Localized string.</returns>
        /// \new491 Added in version 4.9.1
        public string get_LocalizedString(tkLocalizedStrings str)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the localized version for a specified string used in GUI.
        /// </summary>
        /// <param name="str">String to set localized version for.</param>
        /// <param name="retVal">Localized string.</param>
        /// \new491 Added in version 4.9.1
        public void set_LocalizedString(tkLocalizedStrings str, string retVal)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets or sets colour scheme to be used for rendering grids.
        /// </summary>
        /// <remarks>The value will be used on passing Grid object to AxMap.AddLayer method.</remarks>
        /// \new491 Added in version 4.9.1
        public PredefinedColorScheme DefaultColorSchemeForGrids
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets initial value to be set for Shapefile.GeometryEngine property of newly created shapefiles.
        /// </summary>
        /// \new491 Added in version 4.9.1
        public tkGeometryEngine GeometryEngine
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets a value indicating whether colour scheme set in 
        /// GlobalsSettings.DefaultColorSchemeForGrids or a radom one should be used on opening grids.
        /// </summary>
        /// <remarks>The value will be used on passing Grid object to AxMap.AddLayer method.</remarks>
        /// \new491 Added in version 4.9.1
        public bool RandomColorSchemeForGrids
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets a value indicating whether colour scheme for grid will be saved to .mwleg 
        /// to be reused on the next opening.
        /// </summary>
        /// <remarks>This value affects only grid datasources rendered by Image class directly.
        /// Colour scheme for proxy images will be written on disk despite this values. Without them those proxies become meaningless.</remarks>
        /// \new491 Added in version 4.9.1
        public bool SaveGridColorSchemeToFile
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Sets validation mode for input of geoprocessing operations.
        /// </summary>
        /// <remarks>This setting affects only Shapefile objects, while it it doesn't affect
        /// single shapes passed as parameters. Check results of validation in Shapefile.LastInputValidation.</remarks>
        /// \new491 Added in version 4.9.1
        public tkShapeValidationMode ShapeInputValidationMode
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Sets validation mode for output of geoprocessing operations.
        /// </summary>
        /// <remarks>This setting affects only methods where Shapefile objects are returned as output,
        /// single shapes returned as output are not affected. Check results of validation in Shapefile.LastOutputValidation.</remarks>
        /// \new491 Added in version 4.9.1
        public tkShapeValidationMode ShapeOutputValidationMode
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets default value of Image.DownsamplingMode property.
        /// </summary>
        /// \new492 Added in version 4.9.2
        public tkInterpolationMode ImageDownsamplingMode
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets default value of Image.UpsamplingMode property.
        /// </summary>
        /// \new492 Added in version 4.9.2
        public tkInterpolationMode ImageUpsamplingMode
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets a value indicating whether layer symbology from .mwsymb XML file
        /// should be automatically applied on adding layer to the map.
        /// </summary>
        /// \new492 Added in version 4.9.2
        public bool LoadSymbologyOnAddLayer
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets the minimum width of image for GDAL overviews to be created.
        /// For images with smaller width no GDAL overviews will be created. 
        /// </summary>
        /// \new492 Added in version 4.9.2
        public int MinOverviewWidth
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets a value indicating whether automatic creation of GDAL overviews will
        /// be performed for large datasets.
        /// </summary>
        /// <remarks>Currently applied to grid datasets only (both direct and proxy rendeing).
        /// No automatic overview creation for RGB image is implemented so far.</remarks>
        /// \new492 Added in version 4.9.2
        public tkRasterOverviewCreation RasterOverviewCreation
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets resampling method for creation of GDAL overviews.
        /// </summary>
        /// \new492 Added in version 4.9.2
        public tkGDALResamplingMethod RasterOverviewResampling
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets compression mode to be used for TIFF proxies created for grid rendering.
        /// </summary>
        /// \new492 Added in version 4.9.2
        public tkTiffCompression TiffCompression
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets minimum available zoom level for tiles when map projection and server projection don't match.
        /// </summary>
        /// <remarks>This value will be used for any provider which uses Spherical Mercator projection
        /// while map projection isn't set to Spherical Mercator or WGS84. The default value is 6.
        /// Smaller zoom levels (1-5) typically have severe distortions caused by coordinate transformation
        /// which makes them unusable. Tiles won't be displayed at all for these levels and they will 
        /// not be included into zoom bar.</remarks>
        /// \new492 Added in version 4.9.2
        public int TilesMinZoomOnProjectionMismatch
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets the number of threads to be used for downloading tiles from remote server.
        /// Default value is 5. Increasing the number of threads doesn't necessarily lead to better 
        /// performance as servers may limit the number of simultaneous connections from the same IP 
        /// address.
        /// </summary>
        /// \new492 Added in version 4.9.2
        public int TilesThreadPoolSize
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets string encoding used to communicate with OGR drivers.
        /// </summary>
        /// \new493 Added in version 4.9.3
        public tkOgrEncoding OgrStringEncoding
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets the maximum number of features that can be loaded into memory for a single 
        /// OGR layer.
        /// </summary>
        /// \see OgrLayer.MaxFeatureCount
        /// \new493 Added in version 4.9.3
        public int OgrLayerMaxFeatureCount { get; set; }

        /// <summary>
        /// Gets or sets a value which indicates whether OgrLayer.DynamicLoading mode will
        /// chosen automatically based on the number of features. The default value is true.
        /// </summary>
        /// \new493 Added in version 4.9.3
        public bool AutoChooseOgrLoadingMode { get; set; }

        /// <summary>
        /// Gets or sets maximum number of shapes within view for hot tracking functionality to work.
        /// </summary>
        /// <remarks>Hot tracking is used by cmIdentify tool and interactive editing tools.</remarks>
        /// \see Identifier.HotTracking, ShapeEditor.HighlightVertices.
        /// \new493 Added in version 4.9.3
        public int HotTrackingMaxShapeCount
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets a value indicating whether layers without metadata about coordinate system / projection can be added to the map.
        /// </summary>
        /// <remarks>The default value is true. The decision can also be made on per-layer bases
        /// by handling AxMap.LayerProjectionIsEmpty event.</remarks>
        /// \new493 Added in version 4.9.3
        public bool AllowLayersWithoutProjections { get; set;}

        /// <summary>
        /// Gets or sets a value indicating whether layers with coordinate system / projection different from those of the map can be added to the map.
        /// </summary>
        /// <remarks>In most cases it's not advisable to allow projection mismatch, since relative position of layers with different 
        /// projections won't be correct. The default value is false. The decision can also be made on per-layer bases
        /// by handling AxMap.ProjectionMismatch event.</remarks>
        /// \new493 Added in version 4.9.3
        public bool AllowProjectionMismatch { get; set;}

        /// <summary>
        /// Gets or sets global callback object to report information about progress and errors taking place inside MapWinGIS.
        /// </summary>
        /// <remarks>The callback object set by this property will override all callback set for particular classes 
        /// (like %Shapefile.GlobalCallback, %AxMap.GlobalCallback). Also it will automatically display internal GDAL error messages.</remarks>
        /// \note It's strongly recommended to use this property rather than setting callback for each and every class.
        /// \new493 Added in version 4.9.3
        public ICallback ApplicationCallback { get; set;}

        /// <summary>
        /// Gets or sets a value which limits the maximum number of shapes within a vector layer to run on-the-fly reprojection.
        /// </summary>
        /// <remarks>This property is taken into account when projection mismatch occurs on adding a new layer to the map.</remarks>
        /// \new493 Added in version 4.9.3
        public int MaxReprojectionShapeCount { get; set;}
       
        /// <summary>
        /// Gets or sets a value which determines how close to a particular object mouse cursor should be 
        /// in order to select it with mouse click. 
        /// </summary>
        /// \new493 Added in version 4.9.3
        public double MouseTolerance { get; set;}

        /// <summary>
        /// Gets or sets a value which determines whether automatic on-the-fly reprojection of the vector layer
        /// will be performed on adding a new layer to the map with different projection.
        /// </summary>
        /// <remarks>The decision can also be made on per-layer bases by handling AxMap.ProjectionMismatch event.</remarks>
        /// \see MaxReprojectionShapeCount
        /// \new493 Added in version 4.9.3
        public bool ReprojectLayersOnAdding { get; set;}

        /// <summary>
        /// When set to true rendering hint for Labels will be chosen automatically to ensure better performance and visual quality.
        /// </summary>
        /// \see Labels.TextRednderingHint
        /// \new493 Added in version 4.9.3
        public bool AutoChooseRenderingHintForLabels { get; set;}

        /// <summary>
        /// When set to true, any labels added to any instance of AxMap won't be rendered.
        /// </summary>
        /// \new493 Added in version 4.9.3
        public bool ForceHideLabels { get; set;}

        /// <summary>
        /// Gets the version of GDAL library which current build of MapWinGIS uses.
        /// </summary>
        /// \new493 Added in version 4.9.3
        public string GdalVersion { get { throw new NotImplementedException(); } }

        /// <summary>
        /// When set to true the opening of any OGR layer will be first made with forUpdate parameter. 
        /// If this first attempt fails, the layer will be opened without update flag.
        /// </summary>
        /// \see OgrLayer.SupportsEditing
        /// \new493 Added in version 4.9.3
        public bool OgrLayerForceUpdateMode { get; set;}

        /// <summary>
        /// Gets or sets pixel offset mode to be used during the rendering of vector layers.
        /// </summary>
        /// \new493 Added in version 4.9.3
        public tkPixelOffsetMode PixelOffsetMode { get; set;}

        /// <summary>
        /// Gets or sets the path where data necessary for GDAL coordinate systems / projections will be searched for.
        /// </summary>
        /// <remarks>This property effectively overrides GDAL_DATA environment variable. By default
        /// it's set to gdal-data folder in the directory where MapWinGIS is installed.</remarks>
        /// \new493 Added in version 4.9.3
        public string GdalDataPath { get; set;}

        /// <summary>
        /// Gets or sets the path where GDAL plug-ins will be searched for.
        /// </summary>
        /// <remarks>This property effectively overrides GDAL_DRIVER_PATH environment variable. By default
        /// it's set to gdalplugins folder in the directory where MapWinGIS is installed.</remarks>
        /// \new493 Added in version 4.9.3
        public string GdalPluginPath { get; set;}


        /// <summary>
        /// Gets or sets API key to access Bing maps. Without API key Bing Maps provider isn't available. See 
        /// <a href = "https://mapwingis.codeplex.com/wikipage?title=onlinetiles">details here</a>. 
        /// </summary>
        /// \new493 Added in version 4.9.3
        public string BingApiKey { get; set;}
       
        /// <summary>
        /// Sets application credentials for Here Maps online tiles. 
        /// Without these credentials Here Maps providers are not available. See 
        /// <a href = "https://mapwingis.codeplex.com/wikipage?title=onlinetiles">details here</a>. 
        /// </summary>
        /// <param name="appId">Application Id. Can be obtained by registering on the site of the service.</param>
        /// <param name="appCode">Application code. Can be obtained by registering on the site of the service.</param>
        /// \new493 Added in version 4.9.3
        public void SetHereMapsApiKey(string appId, string appCode)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Requests URL address for tiles download from Bing Maps server. 
        /// </summary>
        /// <param name="Key">API key to test.</param>
        /// <returns>True if the Url for downloading for obtained.</returns>
        /// \new493 Added in version 4.9.3
        public bool TestBingApiKey(string Key)
        {
            throw new NotImplementedException();
        }
    }
#if nsp
}
#endif
