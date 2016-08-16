(function () {
    "use strict";

    angular
        .module("common.services")
        .factory("productResource",
                ["$resource",
                "appSettings",
                productResource]);

    function productResource($resource, appSettings) {
        //console.log("called productResource resource:" + $resource + ", appSettings: " + appSettings.toString());
        return $resource(appSettings.serverPath + "/api/products/:id");
    }

    console.log("loaded productResource");
}());