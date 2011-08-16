# start 
tmux new-session -d -s minecraft 'sudo -u minecraft -i "cd minecraft_server && java -Xms32M -Xmx512M -jar minecraft_server.jar nogui"'
