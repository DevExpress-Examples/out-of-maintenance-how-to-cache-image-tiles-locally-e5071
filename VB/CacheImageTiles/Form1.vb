Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace CacheImageTiles
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Create a map control.
            Dim map As New MapControl()

            ' Specify the map position on the form.           
            map.Dock = DockStyle.Fill

            ' Add the map control to the window.
            Me.Controls.Add(map)

            ' Create an image tiles layer and add it to the map.
            Dim tilesLayer As New ImageLayer()
            map.Layers.Add(tilesLayer)

            ' Create an Open Street data provider.
            Dim provider As New OpenStreetMapDataProvider()
            tilesLayer.DataProvider = provider

            ' Customize a local cache for storing image tiles obtained from the Open Street provider.
            provider.CacheOptions.DiskFolder = "C://MapTiles"
            provider.CacheOptions.DiskExpireTime = New TimeSpan(01,00,00)
            provider.CacheOptions.MemoryLimit = 64
            provider.CacheOptions.DiskLimit = 200
        End Sub
    End Class
End Namespace
