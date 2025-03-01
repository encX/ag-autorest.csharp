
# Agoda-autorest

This is the autorest extension for agoda which uses the roundrobin client.
The [AutoRest](https://github.com/Azure/autorest) tool generates client libraries for accessing RESTful web services.
## Usage

you should either put your swagger in the path `./input/swagger.json` OR pass the option variable `SPEC_FILE`

`SPEC_FILE` can be a Url or a path, if it is a Url it will downlaoded, if its  path it must be a path raltive to the working folder (e.g. `./input/anotherswagger.json`) , or rooted in the `/src` mount (e.g. `/src/input/anotherswagger.json`)

```bash
docker run -v ${PWD}:/src -e NUGET_KEY=xxxxxxxxxxxx \
-e SPEC_FILE=http://path/to/your/swagger.yaml \
-e CLIENT_NAMESPACE=Your.App.Namespace \
-e VERSION=2.0.25 \
your-org-repo/autorest-gen:latest
```

### Varibles

| Varible Name       | What it does? | DEFAULT |
| ------------------ | ------------- | ------- |
| NUGET_KEY*         | Api Key for nuget server | 
| SPEC_FILE          | Url or path to Swagger/Open API Spec | /src/input/swagger.json |
| VERSION*           | Versin of the outputed nuget package | |
| CLIENT_NAMESPACE*  | Namespace and assembly name for the gerenated package |
| USE_OPENAPI_V3     | is the swagger/open api spec v3? | false |
| USE_DATETIMEOFFSET | Should use DateTimeOffset in place of DateTime data type? | false |
| SHOULD_PUSH_NUGET  | Should push to nuget server after the package is built? | true |

* Required

#### Test on Local
- Clone this repo with `git clone --recursive`
  -- if you alraedy cloned and want to load the submodules run `git submodule update --init`
- Modify docker-compose.yml as the detail inside
- run docker-compose up --build
- check the result at the location you set in the volume
