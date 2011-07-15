# Show some info about everything we have so far.
openssl rsa -noout -text -in server.key
openssl req -noout -text -in server.csr
openssl rsa -noout -text -in ca.key
openssl x509 -noout -text -in ca.crt
