// Write your JavaScript code.
NotifySuccess = function (message) {
    Notify(message, 'top-right', '5000', 'success', 'fa-check', true);
};

NotifyError = function (message) {
    Notify(message, 'top-right', '20000', 'danger', 'fa-warning', true);
};
AddAntiForgeryToken = function (data) {
    data.__RequestVerificationToken = $('[name=__RequestVerificationToken]').val();
    return data;
};

function Notify(message, position, timeout, theme, icon, closable) {
    Toastr.options.positionClass = 'toast-' + position;
    Toastr.options.extendedTimeOut = 0; //1000;
    Toastr.options.timeOut = timeout;
    Toastr.options.closeButton = closable;
    Toastr.options.iconClass = icon + ' toast-' + theme;
    Toastr['custom'](message);
}