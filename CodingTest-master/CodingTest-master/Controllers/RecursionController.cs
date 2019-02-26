using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodingTest.Controllers
{
    public class RecursionController : Controller
    {
        public IActionResult Index()
        {
            // This is the location I moved Canada under North America, and Central and South under Americas
            Location location = new Location()
            {
                Name = LocationList.Name,
                ChildrenLocations = LocationList.ChildrenLocations
            };

            // This is the original location list. You can uncomment this and comment the above to this original list
            //Location location = new Location()
            //{
            //    Name = LocationList_ORIG.Name,
            //    ChildrenLocations = LocationList_ORIG.ChildrenLocations
            //};

            return View(location);
        }

        // Copied the original to this list and moved Canada under North America, Central and South under Americas
        private static Location LocationList = new Location
        {
            Name = "Americas",
            ChildrenLocations = new List<Location>
            {
                new Location
                {
                    Name = "North America",
                    ChildrenLocations = new List<Location>
                    {
                        new Location
                        {
                            Name = "United States",
                            ChildrenLocations = new List<Location>
                            {
                                new Location {Name="Illinois"},
                                new Location {Name="Iowa"},
                                new Location {Name="New York"},
                                new Location {Name="Texas"},
                                new Location {Name="West Virginia"},
                                new Location {Name="Utah"},
                                new Location {Name="Vermont"},
                                new Location {Name="Kansas"},
                                new Location {Name="Washington"},
                                new Location {Name="Indiana"},
                                new Location {Name="Wisconsin"},
                                new Location {Name="California"},
                                new Location {Name="Arizona"},
                                new Location {Name="Colorado"},
                                new Location {Name="Montana"},
                                new Location {Name="Arkansas"},
                                new Location {Name="Tennessee"},
                                new Location {Name="New Jersey"},
                                new Location {Name="New Mexico"},
                                new Location {Name="Virginia"},
                                new Location {Name="Connecticut"},
                                new Location {Name="Kentucky"},
                                new Location {Name="Maryland"},
                                new Location {Name="Massachusetts"},
                                new Location {Name="Louisiana"},
                                new Location {Name="Maine"},
                                new Location {Name="Nebraska"},
                                new Location {Name="Nevada"},
                                new Location {Name="Alabama"},
                                new Location {Name="Hawaii"},
                                new Location {Name="North Dakota"},
                                new Location {Name="Ohio"},
                                new Location {Name="Idaho"},
                                new Location {Name="South Dakota"},
                                new Location {Name="Wyoming"},
                                new Location {Name="Alaska"},
                                new Location {Name="Delaware"},
                                new Location {Name="Michigan"},
                                new Location {Name="Minnesota"},
                                new Location {Name="Florida"},
                                new Location {Name="Georgia"},
                                new Location {Name="New Hampshire"},
                                new Location {Name="North Carolina"},
                                new Location {Name="Oklahoma"},
                                new Location {Name="Oregon"},
                                new Location {Name="Pennsylvania"},
                                new Location {Name="Rhode Island"},
                                new Location {Name="South Carolina"},
                                new Location {Name="Mississippi"},
                                new Location {Name="Missouri"}
                            }
                        },
                        new Location
                        {
                            Name = "Canada",
                            ChildrenLocations = new List<Location>
                            {
                                new Location {Name="Quebec"},
                                new Location {Name="British Columbia"},
                                new Location {Name="Saskatchewan"},
                                new Location {Name="New Brunswick"},
                                new Location {Name="Alberta"},
                                new Location {Name="Newfoundland and Labrador"},
                                new Location {Name="Manitoba"},
                                new Location {Name="Nova Scotia"},
                                new Location {Name="Prince Edward Island"},
                                new Location {Name="Ontario"}

                            }
                        }
                    }
                },
                new Location
                {
                    Name = "Central American",
                    ChildrenLocations = new List<Location>
                    {
                        new Location {Name="Honduras"},
                        new Location {Name="El Salvador"},
                        new Location {Name="Costa Rica"},
                        new Location {Name="Panama"},
                        new Location {Name="Guatemala"},
                        new Location {Name="Belize"},
                        new Location {Name="Nicaragua"}
                    }
                },
                new Location
                {
                    Name = "South American",
                    ChildrenLocations = new List<Location>
                    {
                        new Location {Name="Bouvet Island"},
                        new Location {Name="Paraguay"},
                        new Location {Name="Colombia"},
                        new Location {Name="Brazil"},
                        new Location {Name="Argentina"},
                        new Location {Name="Venezuela"},
                        new Location {Name="French Guiana"},
                        new Location {Name="Guyana"},
                        new Location {Name="South Georgia and the South Sandwich Islands"},
                        new Location {Name="Bolivia"},
                        new Location {Name="Peru"},
                        new Location {Name="Uruguay"},
                        new Location {Name="Suriname"},
                        new Location {Name="Ecuador"},
                        new Location {Name="Chile"},
                        new Location {Name="Falkland Islands"}
                    }
                }
            }
        };


        /// <summary>
        /// The original list
        /// </summary>
        private static Location LocationList_ORIG = new Location
        {
            Name = "Americas",
            ChildrenLocations = new List<Location>{
                new Location
                {
                    Name = "North America",
                    ChildrenLocations = new List<Location>
                    {
                        new Location
                        {
                            Name = "United States",
                            ChildrenLocations = new List<Location>
                            {
                                new Location {Name="Illinois"},
                                new Location {Name="Iowa"},
                                new Location {Name="New York"},
                                new Location {Name="Texas"},
                                new Location {Name="West Virginia"},
                                new Location {Name="Utah"},
                                new Location {Name="Vermont"},
                                new Location {Name="Kansas"},
                                new Location {Name="Washington"},
                                new Location {Name="Indiana"},
                                new Location {Name="Wisconsin"},
                                new Location {Name="California"},
                                new Location {Name="Arizona"},
                                new Location {Name="Colorado"},
                                new Location {Name="Montana"},
                                new Location {Name="Arkansas"},
                                new Location {Name="Tennessee"},
                                new Location {Name="New Jersey"},
                                new Location {Name="New Mexico"},
                                new Location {Name="Virginia"},
                                new Location {Name="Connecticut"},
                                new Location {Name="Kentucky"},
                                new Location {Name="Maryland"},
                                new Location {Name="Massachusetts"},
                                new Location {Name="Louisiana"},
                                new Location {Name="Maine"},
                                new Location {Name="Nebraska"},
                                new Location {Name="Nevada"},
                                new Location {Name="Alabama"},
                                new Location {Name="Hawaii"},
                                new Location {Name="North Dakota"},
                                new Location {Name="Ohio"},
                                new Location {Name="Idaho"},
                                new Location {Name="South Dakota"},
                                new Location {Name="Wyoming"},
                                new Location {Name="Alaska"},
                                new Location {Name="Delaware"},
                                new Location {Name="Michigan"},
                                new Location {Name="Minnesota"},
                                new Location {Name="Florida"},
                                new Location {Name="Georgia"},
                                new Location {Name="New Hampshire"},
                                new Location {Name="North Carolina"},
                                new Location {Name="Oklahoma"},
                                new Location {Name="Oregon"},
                                new Location {Name="Pennsylvania"},
                                new Location {Name="Rhode Island"},
                                new Location {Name="South Carolina"},
                                new Location {Name="Mississippi"},
                                new Location {Name="Missouri"}
                            }
                        },
                        new Location
                        {
                            Name = "Central American",
                            ChildrenLocations = new List<Location>
                            {
                                new Location {Name="Honduras"},
                                new Location {Name="El Salvador"},
                                new Location {Name="Costa Rica"},
                                new Location {Name="Panama"},
                                new Location {Name="Guatemala"},
                                new Location {Name="Belize"},
                                new Location {Name="Nicaragua"}
                            }
                        },
                        new Location
                        {
                            Name = "South American",
                            ChildrenLocations = new List<Location>
                            {
                                new Location {Name="Bouvet Island"},
                                new Location {Name="Paraguay"},
                                new Location {Name="Colombia"},
                                new Location {Name="Brazil"},
                                new Location {Name="Argentina"},
                                new Location {Name="Venezuela"},
                                new Location {Name="French Guiana"},
                                new Location {Name="Guyana"},
                                new Location {Name="South Georgia and the South Sandwich Islands"},
                                new Location {Name="Bolivia"},
                                new Location {Name="Peru"},
                                new Location {Name="Uruguay"},
                                new Location {Name="Suriname"},
                                new Location {Name="Ecuador"},
                                new Location {Name="Chile"},
                                new Location {Name="Falkland Islands"}
                            }
                        },
                        new Location
                        {
                            Name = "Canada",
                            ChildrenLocations = new List<Location>
                            {
                                new Location {Name="Quebec"},
                                new Location {Name="British Columbia"},
                                new Location {Name="Saskatchewan"},
                                new Location {Name="New Brunswick"},
                                new Location {Name="Alberta"},
                                new Location {Name="Newfoundland and Labrador"},
                                new Location {Name="Manitoba"},
                                new Location {Name="Nova Scotia"},
                                new Location {Name="Prince Edward Island"},
                                new Location {Name="Ontario"}

                            }
                        }
                    }
                }
            }
        };
    }
}