# JWT-token registration app based on Angular 4 & ASP.NET Core 2.0

## Introduction

[![Build Status](https://travis-ci.org/osya/ASPNetCoreAngular2YoExample.svg?branch=master)](https://travis-ci.org/osya/ASPNetCoreAngular2YoExample) [![Build status](https://ci.appveyor.com/api/projects/status/ijoo2enx0h6d4n88/branch/master?svg=true)](https://ci.appveyor.com/project/osya/aspnetcoreangular2yoexample/branch/master) [![Coverage Status](https://coveralls.io/repos/github/osya/ASPNetCoreAngular2YoExample/badge.svg?branch=master)](https://coveralls.io/github/osya/ASPNetCoreAngular2YoExample?branch=master)

Used technologies:

- ASP.NET Core MVC 2.0 & Angular 4
- Testing: Karma
- Assets management: NPM & Webpack
- Travis CI

## Installation

Before creating Docker container:

```shell
    npm install
    node node_modules/webpack/bin/webpack.js --config webpack.config.vendor.js --env.prod
    node node_modules/webpack/bin/webpack.js --env.prod
```

Launching:

```shell
    docker-compose up
```

## Usage

Open the following URL in a browser <http://192.168.99.100/>

## Tests
