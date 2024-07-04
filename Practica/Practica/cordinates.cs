using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    internal class cordinates
    {
      

        static public GMapControl gMapControl1 = new GMapControl();

        public class ApiResult
        {
            public List<BranchData> data { get; set; }
        }

        public class BranchData
        {
            public PostalAddress postalAddress { get; set; }
        }

        public class PostalAddress
        {
            public string[] addressLine { get; set; }
            public GeographicCoordinates geographicCoordinates { get; set; }
        }

        public class GeographicCoordinates
        {
            public Geolocation geolocation { get; set; }
        }

        public class Geolocation
        {
            public string latitude { get; set; }
            public string longitude { get; set; }
        }
        public class LocationData
        {
            public string[] AddressLine { get; set; }
            public string Longitude { get; set; }
            public string Latitude { get; set; }
        }

        public static async Task getMarkers()
        {

            string apiUrl = "https://belarusbank.by/open-banking/v1.0/banks/AKBBBY2X/branches";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();

                        if (!string.IsNullOrEmpty(content))
                        {
                            var apiResult = JsonConvert.DeserializeObject<ApiResult>(content);
                            var locations = new List<LocationData>();

                            foreach (var branchData in apiResult.data)
                            {
                                var postalAddress = branchData.postalAddress;

                                // Создание объекта LocationData
                                var location = new LocationData
                                {
                                    AddressLine = postalAddress.addressLine,
                                    Longitude = postalAddress.geographicCoordinates.geolocation.longitude,
                                    Latitude = postalAddress.geographicCoordinates.geolocation.latitude
                                };

                                // Добавление в список
                                locations.Add(location);
                            }

                            var cordinatesInstance = new cordinates(); // Создание экземпляра класса
                            gMapControl1.Overlays.Add(cordinatesInstance.GetOverlayMarkers(locations, "GroupsMarkers"));
                            gMapControl1.Overlays.Add(cordinatesInstance.GetOverlayMarkers(locations, " GroupsMarkers", GMarkerGoogleType.blue));
                            gMapControl1.Overlays[0].IsVisibile = true;
                            gMapControl1.Update();
                        }
                        else
                        {
                            Console.WriteLine("Получен пустой ответ от API.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка при выполнении запроса: {response.StatusCode}");
                    }
                } 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }

        public void loadMap()
        {
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly; 
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gMapControl1.MinZoom = 2; 
            gMapControl1.MaxZoom = 16; 
            gMapControl1.Zoom = 8;
            gMapControl1.Position = new GMap.NET.PointLatLng(53.7639482, 27.9114719);
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter; 
            gMapControl1.CanDragMap = true; 
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.ShowCenter = false; 
            gMapControl1.ShowTileGridLines = false; 
            gMapControl1.Visible = true;
            getMarkers();
        }

        private GMarkerGoogle GetMarker(double latitude, double longitude, string[] addressLine, GMarkerGoogleType gMarkerGoogleType = GMarkerGoogleType.blue)
        {
            GMarkerGoogle mapMarker = new GMarkerGoogle(new GMap.NET.PointLatLng(latitude , longitude ), gMarkerGoogleType);//широта, долгота, тип маркера
            mapMarker.ToolTip = new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(mapMarker);//всплывающее окно с инфой к маркеру
            mapMarker.ToolTipText = string.Concat(addressLine); // текст внутри всплывающего окна
            mapMarker.ToolTipMode = MarkerTooltipMode.OnMouseOver; //отображение всплывающего окна (при наведении)
            return mapMarker;
        }

        private GMapOverlay GetOverlayMarkers(List<LocationData> bankCordinate, string name, GMarkerGoogleType gMarkerGoogleType = GMarkerGoogleType.blue)
        {
            GMapOverlay gMapMarkers = new GMapOverlay(name); // Создание именованного слоя

            foreach (var item in bankCordinate)
            {
                // Создайте маркер для каждой координаты
                gMapMarkers.Markers.Add(GetMarker(double.Parse(item.Latitude), double.Parse(item.Longitude),item.AddressLine, gMarkerGoogleType));// добавление маркеров на слой 

           
            }

            return gMapMarkers;
        }
    }
}
