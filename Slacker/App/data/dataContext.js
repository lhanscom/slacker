    'use strict';

    var serviceId = 'dataContext';

    angular
        .module('slacker')
        .factory(serviceId, dataContext);

    dataContext.$inject = ['$http', '$q'];

    function dataContext($http, $q) {

        var service = {
            getSongs: getSongs
        };

        return service;


        function getSongs() {
            return _getHttp('/api/songs/Get');
        }

        //privates

        function _parameterizeUrl(url, parameterMap) {
            var urlParameterRegex = /([/?&])([^:/?&]+)?(:([^/?&]+))/g;

            parameterMap = parameterMap || {};

            var missingParameterNames = [];

            url = url.replace(urlParameterRegex, function (match, delimiter, assignment, parameterDeclaration, parameterName) {
                var parameterValue = parameterMap[parameterName];
                //if (typeof parameterValue === 'undefined') {
                //    missingParameterNames.push(parameterName);
                //}

                if (parameterValue) {
                    var value = delimiter;
                    if (assignment) {
                        value += assignment;
                    }

                    value += parameterValue;

                    return value;
                } else {
                    if (delimiter === '?' || delimiter === '/') {
                        return delimiter;
                    } else {
                        return '';
                    }
                }
            });

            if (missingParameterNames.length > 0) {
                throw new UrlParameterException(url, parameterMap, missingParameterNames);
            }

            return url;

        }

        function _deleteHttp(url, parameters) {
            return _useHttp("delete", url, null, parameters);
        }

        function _getHttp(url, parameters, supress404) {
            return _useHttp("get", url, null, parameters, supress404);
        }

        function _postHttp(url, data, parameters) {
            return _useHttp("post", url, data, parameters);
        }

        function _useHttp(method, url, data, parameters, supress404) {
            var def = $q.defer();

            try {
                url = _parameterizeUrl(url, parameters);
            } catch (error) {
                def.reject(error);
                return def.promise;
            }

            var req = {
                method: method,
                url: url,
                data: data
            };

            $http(req).success(success).error(failure);

            return def.promise;

            function success(response) {
                def.resolve(response);
            }

            function failure(data, status, headers, config) {
                def.reject(data);
            }
        }

        function UrlParameterException(url, parameters, missingParameterNames) {
            this.message = 'The following parameters are required: "' + missingParameterNames.join(', ') + '" for the url "' + url + "' but were not supplied.";
            this.url = url;
            this.suppliedParameters = parameters;
            this.missingParameterNames = missingParameterNames;
        }
    }