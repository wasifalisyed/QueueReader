﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.WindowsAzure.Storage.Queue;

namespace QueueReader
{
    public class Functions
    {
        // This function will get triggered/executed when a new message is written 
        // on an Azure Queue called queue.
        public static void ProcessQueueMessage([QueueTrigger("messagequeue")] string message, [Queue("result")]CloudQueue resultQueue)
        {

            CloudQueueMessage msg = new CloudQueueMessage(message);
            resultQueue.AddMessage(msg);
            // hello wasif . this is your first comment

        }
    }
}
