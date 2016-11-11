String.prototype.capitalise = function () {
    return this.charAt(0).toUpperCase() + this.slice(1);
}

String.prototype.camelCaseToSpineCase = function () {
    return this.replace(/([A-Z])/g, function ($1) { return "-" + $1.toLowerCase(); });
}

String.prototype.spineCaseToCamelCase = function () {

    var temp = this.replace(/(-)(\w)/g, function ($1) { return $1.toUpperCase(); });

    return temp.replace(/-/g, '');
}

String.prototype.format = function () {
    // http://stackoverflow.com/questions/18405736/is-there-a-c-sharp-string-format-equivalent-in-javascript
    var args = arguments;
    return this.replace(/{(\d+)}/g, function (match, number) {
        return typeof args[number] != 'undefined'
          ? args[number]
          : match
        ;
    });
}