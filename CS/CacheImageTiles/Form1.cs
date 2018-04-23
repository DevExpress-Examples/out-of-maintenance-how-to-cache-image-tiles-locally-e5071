using System;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace CacheImageTiles {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a map control.
            MapControl map = new MapControl();

            // Specify the map position on the form.           
            map.Dock = DockStyle.Fill;

            // Add the map control to the window.
            this.Controls.Add(map);

            // Create an image tiles layer and add it to the map.
            ImageTilesLayer tilesLayer = new ImageTilesLayer();
            map.Layers.Add(tilesLayer);

            // Create an Open Street data provider.
            OpenStreetMapDataProvider provider = new OpenStreetMapDataProvider();
            tilesLayer.DataProvider = provider;

            // Customize a local cache for storing image tiles obtained from the Open Street provider.
            provider.CacheOptions.DiskFolder = "C://MapTiles"; 
            provider.CacheOptions.DiskExpireTime = new TimeSpan(01,00,00);
            provider.CacheOptions.MemoryLimit = 64;           
            provider.CacheOptions.DiskLimit = 200;
        }
    }
}
