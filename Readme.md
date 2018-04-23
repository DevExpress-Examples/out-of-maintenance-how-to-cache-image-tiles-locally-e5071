# How to cache image tiles locally


<p><br />
This example illustrates what is required to customize the local cache of a map control. <br />
</p><p>The local cache allows you to save internet resources and significantly increase map performance by loading saved map tiles from the local directory. <br />
</p><p>To enable map cache,  specify the directory to which the loaded  map tiles will be saved using the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapCacheOptions_DiskFoldertopic"><u>CacheOptions.DiskFolder</u></a> property and the time interval after which the loaded map tiles should be updated using the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapCacheOptions_DiskExpireTimetopic"><u>CacheOptions.DiskExpireTime</u></a> property.  To access the <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapCacheOptionstopic"><u>CacheOptions</u></a> object, use the  <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapMapDataProviderBase_CacheOptionstopic"><u>MapDataProviderBase.CacheOptions</u></a> property. </p><p>In addition you can specify the amount of memory on the computer and disk space, in megabytes, for storing tile images via <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapCacheOptions_MemoryLimittopic"><u>CacheOptions.MemoryLimit</u></a> and <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapCacheOptions_DiskLimittopic"><u>CacheOptions.DiskLimit</u></a> properties, correspondingly.  </p><p>In this example tile images of a map are loaded from the <a href="http://www.openstreetmap.org/"><u>OpenStreetMap</u></a> resource. </p><br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />


<br/>


