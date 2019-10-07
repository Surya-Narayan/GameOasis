# Team
Multiplayer Game implemented on Marlin Protocol blockchain network

ABOUT:
The main obejctive of this game is to collect all collectives present for that respective player without touching each other and both
beating the timer before it runs out.Both players will be playing on their respective systems and will be connected through and 
since the game has been deployed on Unity, we will not be using the unity server but instead join marlin through another socket connection
using WebSocketSharp. It will run as client in player system and another independent system will run the server side and connect it to the network 
for udp based protocol transactions.

PROCEDURE:
1.Download the whole setup
2.Import into Unity app
3.Among Player1,2 and spectator mode, delete either of the 2 and make sure theyre different in another players system
4.Build and run
5.Play 

IMPROVISATION : 
There is a bit of synchronization problem among the devices causing the game to be a little slow in ones pc compared to another due to 
unity deterministic engine which is processor based causing differences in gameplay between a faster and a slower processor system and hence 
hardware similarity is preferred.


