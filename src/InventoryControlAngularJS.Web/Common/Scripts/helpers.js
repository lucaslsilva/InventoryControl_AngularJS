var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('InventoryControlAngularJS');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);