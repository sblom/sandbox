# Then we create a cert and csr for our server.
openssl genrsa -des3 -out server.key 4096
openssl req -new -key server.key -out server.csr
