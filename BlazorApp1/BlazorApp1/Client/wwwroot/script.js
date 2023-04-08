function initialize() {
    var latlng = new google.maps.LatLng(53.409023, -1.448625);
    var options = {
        zoom: 20, center: latlng,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    var map = new google.maps.Map(document.getElementById("map"), options);
}