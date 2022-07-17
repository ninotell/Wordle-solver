/// <reference path="../knockout-3.4.0.debug.js" />
/// <reference path="../jquery-3.1.1.js" />
/// <reference path="../knockout.mapping-latest.debug.js" />

WordleVM = function (data) {
    var self = this;
    ko.mapping.fromJS(data, {}, self);
    self.newGame = function () {
        $.post(
            {
                url: "/Home/Game",
                data: ko.mapping.toJS(self),
                success: function (response) {
                    ko.applyBindings(data)
                    ko.mapping.fromJS(response, {}, self);
                },
                error: function () {

                }
            });
    }

    self.intentarPalabra = function () {
        $.post(
            {
                url: "/Game/IntentarPalabra",
                data: ko.mapping.toJS(self),
                success: function (response) {
                    ko.mapping.fromJS(response, {}, self);
                    if (self.Win()) {
                        alert("WIN. Has ganado.");
                    }
                    else if (self.ErroresCometidos() == self.ErroresPosibles()) {
                        alert("LOSS. Has perdido.");
                    }
                },
                error: function () {

                }
            })
    }    
}