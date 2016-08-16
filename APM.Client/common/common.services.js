(function () {
    "use strict";

    angular
        .module("common.services", ["ngResource"])
        .constant("appSettings",
        {
            serverPath: "http://localhost:51793"
        });
    console.log("loaded common.services");
}());