﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using GeoCoordinatePortable;

namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();

        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log that and return null
                logger.LogWarning("Error, less than 3 items");
                // Do not fail if one record parsing fails, return null
                return null; // TODO Implement
            }

            // grab the latitude from your array at index 0
            var latitude = Convert.ToDouble(cells[0]);
            // grab the longitude from your array at index 1
            var longitude = Convert.ToDouble(cells[1]);
            // grab the name from your array at index 2
            var TB_location = cells[2];

            // Your going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`

            //Convert.ToDouble(latitude);
            //Convert.ToDouble(longitude); Done in the above declarations

            // You'll need to create a TacoBell class
            // that conforms to ITrackable

            // Then, you'll need an instance of the TacoBell class
            // With the name and point set correctly


            TacoBell tacoBell = new TacoBell();
            {
                tacoBell.Name = TB_location;
                var tacoBellLoco = new Point()
                {
                    Latitude = Convert.ToDouble(latitude),
                    Longitude = Convert.ToDouble(longitude)
                };
                tacoBell.Location = tacoBellLoco;

            }
            // Then, return the instance of your TacoBell class
            // Since it conforms to ITrackable
            return tacoBell;
        }
}
}