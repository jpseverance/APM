(function () {
    "use strict";

    angular
        .module("productManagement")
        .controller("ProductListCtrl",
                     ["productResource",
                         ProductListCtrl]);

    function ProductListCtrl(productResource) {
        console.log("Called ProductListCtrl. productResource: ");
        var vm = this;
        vm.searchCriteria = "GDN";

        productResource.query({search: vm.searchCriteria}, function (data) {
            vm.products = data;
        });
    }

    console.log("Loaded ProductListCtrl");
}());