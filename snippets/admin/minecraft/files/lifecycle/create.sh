# create
echo "deb http://archive.canonical.com/ lucid partner" >> /etc/apt/sources.list
sh -c 'echo sun-java6-jre shared/accepted-sun-dlj-v1-1 select true | /usr/bin/debconf-set-selections';
apt-get update
apt-get install -y sun-java6-jre
apt-get install -y tmux
apt-get install -y ufw

ufw allow proto tcp from any to any port 22
ufw allow proto tcp from any to any port 25565
yes | ufw enable

adduser --disabled-password minecraft < /dev/null

sudo -u minecraft -i curl -H \"X-Auth-Token: $1\" -o minecraft_server.tar.bz2 https://snet-storage101.dfw1.clouddrive.com/v1/MossoCloudFS_f1b63086-0ef5-4ed8-a207-2b8d0663e090/minecraft/minecraft_server.tar.bz2
sudo -u minecraft -i tar xvjf minecraft_server.tar.bz2
