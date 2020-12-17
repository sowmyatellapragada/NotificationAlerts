using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{

    public class VideoUpload
    {
        public EventHandler<subEventArgs> VideoUploadEvent;
        public string publisher { get; set; }
        public void videoupload(string name, ulong mobile, string email)
        {
            Subscriber Obj = new Subscriber();
            Obj.Mobile = mobile;
            Obj.EMail = email;
            Obj.Name = name;
          
            publisher="JOHN ";
            OnVideoUpload(publisher, Obj);
        }
        public virtual void OnVideoUpload(String publ, Subscriber Obj)
        {
            if (VideoUploadEvent != null)
            {
                this.VideoUploadEvent(this, new subEventArgs()
                {
                    Subscriber = Obj,
                    publisher = publ
                });
            }
        }
    }
}