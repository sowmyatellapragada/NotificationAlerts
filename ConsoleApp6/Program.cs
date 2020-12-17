using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoUpload ob = new VideoUpload();
            ob.VideoUploadEvent += NotifySubscriberViaEmail;
            ob.VideoUploadEvent += NotifySubscriberViaSMS;
            
            ob.videoupload("sowmya",6301134751, "sowmyatellapragada@gmail.com");
        } 

        private static void NotifySubscriberViaEmail(object obj, subEventArgs args)
        {
            
            Console.WriteLine("Email received on {0}", args.Subscriber.EMail);
            Console.WriteLine("Hey {0} video is uploaded checkout the channel :  {1}", args.Subscriber.Name, args.publisher);
           
        }

        private static void NotifySubscriberViaSMS(object sender,subEventArgs args)
        {
           
            Console.WriteLine("SMS received on {0}", args.Subscriber.Mobile);
            Console.WriteLine("Hey {0} video is uploaded checkout the channel :  {1}", args.Subscriber.Name, args.publisher);
      
        }

        
    }

}