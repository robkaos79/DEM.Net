﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DEM.Net.Core.Imagery
{
    public partial class ImageryProvider
    {
        public const string ATTRIBUTION_SUBJECT = "Imagery";
#if DEBUG
        public static ImageryProvider DebugProvider = new TileDebugProvider(null);
#endif
        public static ImageryProvider MapBoxSatellite = new ImageryProvider()
        {
            Name = "MapBox-Satellite",
            Attribution = new Attribution(ATTRIBUTION_SUBJECT, "MapBox Satellite", "https://www.mapbox.com", "© MapBox - OpenStreetMap contributors"),
            UrlModel = new UrlModel("https://api.mapbox.com/v4/mapbox.satellite/{z}/{x}/{y}.png?access_token={t}", null),
            TokenUserSecretsKey = "MapBoxToken",
            MaxZoom = 23
        };
        public static ImageryProvider MapBoxSatelliteStreet = new ImageryProvider()
        {
            Name = "MapBox-SatelliteStreet",
            Attribution = new Attribution(ATTRIBUTION_SUBJECT, "MapBox Satellite Street", "https://www.mapbox.com", "© MapBox - OpenStreetMap contributors"),
            UrlModel = new UrlModel("https://api.mapbox.com/v4/mapbox.streets-satellite/{z}/{x}/{y}.png?access_token={t}", null),
            TokenUserSecretsKey = "MapBoxToken",
            MaxZoom = 23
        };
        public static ImageryProvider MapBoxStreets = new ImageryProvider()
        {
            Name = "MapBox-Streets",
            Attribution = new Attribution(ATTRIBUTION_SUBJECT, "MapBox Streets", "https://www.mapbox.com", "© MapBox - OpenStreetMap contributors"),
            TokenUserSecretsKey = "MapBoxToken",
            UrlModel = new UrlModel("https://api.mapbox.com/styles/v1/xfischer/cjbtijn5qahc92qs2yghsy58p/tiles/256/{z}/{x}/{y}?access_token={t}", null),
            MaxZoom = 23
        };
        public static ImageryProvider MapBoxOutdoors = new ImageryProvider()
        {
            Name = "MapBox-Outdoors",
            Attribution = new Attribution(ATTRIBUTION_SUBJECT, "MapBox Outdoors", "https://www.mapbox.com", "© MapBox - OpenStreetMap contributors"),
            TokenUserSecretsKey = "MapBoxToken",
            UrlModel = new UrlModel("https://api.mapbox.com/styles/v1/xfischer/ck77w9wh11jp81ip2rj4kg7xq/tiles/256/{z}/{x}/{y}?access_token={t}", null),
            MaxZoom = 23
        };
        public static ImageryProvider StamenToner = new ImageryProvider()
        {
            Name = "Stamen-Toner",
            Attribution = new Attribution(ATTRIBUTION_SUBJECT, "Stamen Toner", "https://stamen.com/", "Map tiles by <a href=\"http://stamen.com\">Stamen Design</a>, under <a href=\"http://creativecommons.org/licenses/by/3.0\">CC BY 3.0</a>. Data by <a href=\"http://openstreetmap.org\">OpenStreetMap</a>, under <a href=\"http://www.openstreetmap.org/copyright\">ODbL</a>."),
            UrlModel = new UrlModel("http://{s}.tile.stamen.com/toner/{z}/{x}/{y}.png", new[] { "a", "b", "c", "d" }),
            MaxZoom = 14
        };
        public static ImageryProvider StamenWaterColor = new ImageryProvider()
        {
            Name = "Stamen-Watercolor",
            Attribution = new Attribution(ATTRIBUTION_SUBJECT, "Stamen Watercolor", "https://stamen.com/", "Map tiles by <a href=\"http://stamen.com\">Stamen Design</a>, under <a href=\"http://creativecommons.org/licenses/by/3.0\">CC BY 3.0</a>. Data by <a href=\"http://openstreetmap.org\">OpenStreetMap</a>, under <a href=\"http://creativecommons.org/licenses/by-sa/3.0\">CC BY SA</a>."),
            UrlModel = new UrlModel("http://{s}.tile.stamen.com/watercolor/{z}/{x}/{y}.jpg", new[] { "a", "b", "c", "d" }),
            MaxZoom = 14
        };
        public static ImageryProvider OpenTopoMap = new ImageryProvider()
        {
            Name = "OpenTopoMap",
            Attribution = new Attribution(ATTRIBUTION_SUBJECT, "OpenTopoMap",
                                            "Map data: © <a href=\"https://www.openstreetmap.org/copyright\">OpenStreetMap</a> contributors, <a href=\"http://viewfinderpanoramas.org\"> SRTM</a> | Map style: &copy; <a href=\"https://opentopomap.org\" > OpenTopoMap</a> (<a href=\"https://creativecommons.org/licenses/by-sa/3.0/\" > CC-BY-SA</a>)"),
            UrlModel = new UrlModel("https://{s}.tile.opentopomap.org/{z}/{x}/{y}.png", new[] { "a", "b", "c" }),
            MaxZoom = 17
        };
        public static ImageryProvider EsriWorldImagery = new ImageryProvider()
        {
            Name = "Esri.WorldImagery",
            Attribution = new Attribution(ATTRIBUTION_SUBJECT, "Esri World Imagery", "https://services.arcgisonline.com/ArcGIS/rest/services/World_Imagery/MapServer", "Source: Esri, DigitalGlobe, GeoEye, Earthstar Geographics, CNES/Airbus DS, USDA, USGS, AeroGRID, IGN, and the GIS User Community"),
            UrlModel = new UrlModel("https://server.arcgisonline.com/ArcGIS/rest/services/World_Imagery/MapServer/tile/{z}/{y}/{x}", null),
            MaxZoom = 18
        };
        public static ImageryProvider ThunderForestOutdoors = new ImageryProvider()
        {
            Name = "ThunderForest-Outdoors",
            Attribution = new Attribution(ATTRIBUTION_SUBJECT, "ThunderForest", "https://www.thunderforest.com", "Maps © www.thunderforest.com, Data © www.osm.org/copyright"),
            UrlModel = new UrlModel("https://tile.thunderforest.com/outdoors/{z}/{x}/{y}.png?apikey={t}", null),
            TokenUserSecretsKey = "ThunderForestApiKey",
            MaxZoom = 22
        };
        public static ImageryProvider ThunderForestLandscape = new ImageryProvider()
        {
            Name = "ThunderForest-Landscape",
            Attribution = new Attribution(ATTRIBUTION_SUBJECT, "ThunderForest", "https://www.thunderforest.com", "Maps © www.thunderforest.com, Data © www.osm.org/copyright"),
            UrlModel = new UrlModel("https://tile.thunderforest.com/landscape/{z}/{x}/{y}.png?apikey={t}", null),
            TokenUserSecretsKey = "ThunderForestApiKey",
            MaxZoom = 22
        };
        public static ImageryProvider ThunderForestNeighbourhood = new ImageryProvider()
        {
            Name = "ThunderForest-Neighbourhood",
            Attribution = new Attribution(ATTRIBUTION_SUBJECT, "ThunderForest", "https://www.thunderforest.com", "Maps © www.thunderforest.com, Data © www.osm.org/copyright"),
            UrlModel = new UrlModel("https://tile.thunderforest.com/neighbourhood/{z}/{x}/{y}.png?apikey={t}", null),
            TokenUserSecretsKey = "ThunderForestApiKey",
            MaxZoom = 22
        };

    }
}
