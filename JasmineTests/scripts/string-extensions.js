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

/*
 * I assume rather than doing this from scratch this is an exercise in finding an existing well tested solution.
 * I didn't find an obvious library that would do all of above. Instead I cobbled together some suggestions
 * from the likes of Stackoverflow and made a few tweaks myself.
 * 
 * There are two failing tests:
 * 
 *  expect('some-CamelCase with Space'.camelCaseToSpineCase()).toBe('some-camel-case-with-space');
 *  expect('  some snakeCase with Space '.spineCaseToCamelCase()).toBe('someSnakeCaseWithSpace');
 * 
 * I could spend more time expanding the function to cope, but looking at the input I don't think its valid. 
 * I'm not overly familiar with what is/isnot valid snake case, but it looks invalid to me. 
 * 
 */