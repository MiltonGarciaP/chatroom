using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Collections;

namespace RemoteBase
{
   
    public class SampleObject : MarshalByRefObject
    {
       
        Hashtable hTChatMsg=new Hashtable ();
        ArrayList UsuariosOnline = new ArrayList();
        private int key = 0;
        
        public bool JoinToChatRoom(string name)
        {
            if (UsuariosOnline.IndexOf(name) > -1)
                return false;
            else
            {
                UsuariosOnline.Add(name);
                SendMsgToSvr(name + " Se ha unido al chat");
                return true;
            }
            
        }
        public void LeaveChatRoom(string name)
        {
            UsuariosOnline.Remove(name);
            SendMsgToSvr(name + " Ha salido de la sala");
        }
        public ArrayList GetOnlineUser()
        {
            return UsuariosOnline;
        }

        public int CurrentKeyNo()
        {
            return key;
        }
        public void SendMsgToSvr(string chatMsgFromUsr)
        {
            //chatMsg = chatMsgFromUsr;
            hTChatMsg.Add(++key, chatMsgFromUsr);
        }
        public string GetMsgFromSvr(int lastKey)
        {
            if (key > lastKey)
                return hTChatMsg[lastKey + 1].ToString();
            else
                return "";
        }
    }
}
