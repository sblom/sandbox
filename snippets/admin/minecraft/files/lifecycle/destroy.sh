#destroy
sudo -u minecraft -i tar cvjf minecraft_server.tar.bz2 minecraft_server/*
sudo -u minecraft -i curl -i -X PUT -T ~minecraft/minecraft_server.tar.bz2 -H \"X-Auth-Token: $1\" https://snet-storage101.dfw1.clouddrive.com/v1/MossoCloudFS_f1b63086-0ef5-4ed8-a207-2b8d0663e090/minecraft/minecraft_server-`date +%Y%m%d%H%M`.tar.bz2
sudo -u minecraft -i curl -i -X PUT -T ~minecraft/minecraft_server.tar.bz2 -H \"X-Auth-Token: $1\" https://snet-storage101.dfw1.clouddrive.com/v1/MossoCloudFS_f1b63086-0ef5-4ed8-a207-2b8d0663e090/minecraft/minecraft_server.tar.bz2
