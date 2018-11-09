
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
    toastr.options.positionClass = 'toast-' + position;
    toastr.options.extendedTimeOut = 0; //1000;
    toastr.options.timeOut = timeout;
    toastr.options.closeButton = closable;
    toastr.options.iconClass = icon + ' toast-' + theme;
    toastr['custom'](message);
}
