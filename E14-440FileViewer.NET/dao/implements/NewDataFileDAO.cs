﻿using E14_440FileViewer.NET.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using org.tyaa.e14_440fileviewernet.model;
using Moq;
using E14_440FileViewer.NET.model.interfaces;

namespace E14_440FileViewer.NET.dao.implements
{
    class NewDataFileDAO : IDataFilesDAO
    {

        public ChannelsBoundle getChannels()
        {
            //throw new NotImplementedException();

            //TODO prepare channels boundle here

            Console.WriteLine("NewDataFileDAO: getChannels");
            return null;
        }

        public Channel getChannel(int _number)
        {
            throw new NotImplementedException();
        }

        public void persistChannels(ChannelsBoundle _сhannelsBoundle)
        {
            throw new NotImplementedException();
        }
    }
}
