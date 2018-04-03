
//    function initMap(){

//        // 29.784781,30.8499393
//        var location = {lat: -29.784781, lng: 30.8499393}
//        var map = new google.maps.Map(document.getElementById("map"),{
//        zoom: 12,
//            center:location,
//            disableDefaultUI: true,
//            gestureHandling: 'none',
//            zoomControl:false
//        });

//        var contentString = '<div id="content">'+
//            '<div id="siteNotice">'+
//            '</div>'+
//            '<h1 id="firstHeading" class="firstHeading">Merge Media</h1>'+
//            '<div id="bodyContent">'+
//            '<p><b>Merge Media</b>, is a software development company based at 39 Pioneer road in Kloof. They provide software solutions to personal and business clients at affordable pricing.</p>'+
//            '<a href="https://goo.gl/maps/FWG2y6HdQJG2" target="_blank">Click here to navigate to the destination</a>'+
//            '</div>'+
//            '</div>';

//        var infowindow = new google.maps.InfoWindow({
//        content: contentString
//        });

//        var marker = new google.maps.Marker({
//        position: location,
//            map:map,
//            title:"39 Pioneer Road, Kloof."
//        });

//        marker.addListener('click', function() {
//        infowindow.open(map, marker);
//    });
//}
