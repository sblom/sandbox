# Then we sign the server cert, good for one year.
# Don't forget to update the serial number.
openssl x509 -req -days 365 -in server.csr -CA ca.crt -CAkey ca.key -set_serial 2011071501 -out server.crt
