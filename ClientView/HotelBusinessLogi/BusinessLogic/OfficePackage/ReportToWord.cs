using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelBusinessLogic.BusinessLogic.OfficePackage.Enums;
using HotelBusinessLogic.BusinessLogic.OfficePackage.Models;

namespace HotelBusinessLogic.BusinessLogic.OfficePackage
{
    public abstract class ReportToWord
    {
        public  void CreateDocConfRoom(WordInfoConfRoom info)
        {
            CreateWord(info);
            CreateParagraph(new WordParagraph
            {
                Texts = new List<(string, WordTextProperties)> { (info.Title, new
                WordTextProperties { Bold = true, Size = "24", }) },
                TextProperties = new WordTextProperties
                {
                    Size = "24",
                    JustificationType = WordJustificationType.Center
                }
            });
            foreach (var computer in info.ConfRooms)
            {
                CreateParagraph(new WordParagraph
                {
                    Texts = new List<(string, WordTextProperties)> {
                        (computer.ConfDate + ": ", new WordTextProperties {
                        Size = "24",
                        Bold = true
                        })},
                    TextProperties = new WordTextProperties
                    {
                        Size = "24",
                        JustificationType = WordJustificationType.Both
                    }
                });
                for(int i = 0; i<computer.Rooms.Count;i++)
                {
                    CreateParagraph(new WordParagraph
                    {
                        Texts = new List<(string, WordTextProperties)> {
                        ("      "+(i+1)+")"+computer.Rooms[i], new WordTextProperties {
                        Size = "24",
                        Bold = true
                        })},
                        TextProperties = new WordTextProperties
                        {
                            Size = "24",
                            JustificationType = WordJustificationType.Both
                        }
                    });
                }
            }
            SaveWord(info);
        }
        public void CreateDocRoomConf(WordInfoRoomConf info)
        {
            CreateWord(info);
            CreateParagraph(new WordParagraph
            {
                Texts = new List<(string, WordTextProperties)> { (info.Title, new
                WordTextProperties { Bold = true, Size = "24", }) },
                TextProperties = new WordTextProperties
                {
                    Size = "24",
                    JustificationType = WordJustificationType.Center
                }
            });
            foreach (var computer in info.ConfRooms)
            {
                CreateParagraph(new WordParagraph
                {
                    Texts = new List<(string, WordTextProperties)> {
                        (computer.Name + ": ", new WordTextProperties {
                        Size = "24",
                        Bold = true
                        })},
                    TextProperties = new WordTextProperties
                    {
                        Size = "24",
                        JustificationType = WordJustificationType.Both
                    }
                });
                for (int i = 0; i < computer.Confs.Count; i++)
                {
                    CreateParagraph(new WordParagraph
                    {
                        Texts = new List<(string, WordTextProperties)> {
                        ("      "+(i+1)+")"+computer.Confs[i], new WordTextProperties {
                        Size = "24",
                        Bold = true
                        })},
                        TextProperties = new WordTextProperties
                        {
                            Size = "24",
                            JustificationType = WordJustificationType.Both
                        }
                    });
                }
            }
            SaveWord(info);
        }
        protected abstract void CreateWord(WordInfoConfRoom info);
        protected abstract void CreateWord(WordInfoRoomConf info);
        protected abstract void SaveWord(WordInfoConfRoom info);
        protected abstract void CreateParagraph(WordParagraph paragraph);
        protected abstract void SaveWord(WordInfoRoomConf info);
    }
}
