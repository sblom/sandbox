Intro
-----
These are the steps required on a new Ubuntu Server instance (Rackspace
Cloud, Ubuntu 10.04 LTS) to get SSL up and working.

Enable mod_ssl
--------------
This is the least obvious one. mod_ssl is not enabled by default, although
it seems to be installed.

    a2enmod ssl

Once that's done, most of what remains is to configure `/etc/apache2/sites-available/default-ssl`
to use the correct certificate files.
