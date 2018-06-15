# ODataETagTest
Minimal project to demonstrate problem with OData + invalid ETags

Run the project
Use something like POSTMAN to provide an If-None-Match header with the following values:
- X
- "X"
- "7DA93857D637AD1EE0CA1B67F822607F"

They all result in different errors.

We should either have the option to turn off OData processing of etags, or it should handle these errors internally and not bomb out
