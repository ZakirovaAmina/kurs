using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelBusinessLogic.BusinessLogic.OfficePackage.Enums;
using HotelBusinessLogic.BusinessLogic.OfficePackage.Models;

namespace HotelBusinessLogic.BusinessLogic.OfficePackage
{
    public abstract class ReportToPdf
    {
        public void CreateDoc(PdfInfo info)
        {
            CreatePdf(info);
            CreateParagraph(new PdfParagraph
            {
                Text = info.Title,
                Style = "NormalTitle"
            });
            CreateParagraph(new PdfParagraph
            {
                Text = $"с{ info.DateFrom.ToShortDateString() } по { info.DateTo.ToShortDateString() }",
                Style = "Normal"
            });
            CreateTable(new List<string> { "6cm", "6cm", "6cm"});
            CreateRow(new PdfRowParameters
            {
                Texts = new List<string> { "Дата конференции", "Сумма", "Имя клиента",},
                Style = "NormalTitle",
                ParagraphAlignment = PdfParagraphAlignmentType.Center
            });
            foreach (var order in info.Confs)
            {
                CreateRow(new PdfRowParameters
                {
                    Texts = new List<string> { order.DateCreate.ToShortDateString(),order.Sum.ToString(), order.ClientName
                },
                    Style = "Normal",
                    ParagraphAlignment = PdfParagraphAlignmentType.Left
                });
            }
            SavePdf(info);
        }
        public void CreateDocRoom(PdfInfoRoom info)
        {
            CreatePdf(info);
            CreateParagraph(new PdfParagraph
            {
                Text = info.Title,
                Style = "NormalTitle"
            });
            CreateParagraph(new PdfParagraph
            {
                Text = $"с{ info.DateFrom.ToShortDateString() } по { info.DateTo.ToShortDateString() }",
                Style = "Normal"
            });
            CreateTable(new List<string> { "8cm", "8cm" });
            CreateRow(new PdfRowParameters
            {
                Texts = new List<string> { "Услуга", "Количество" },
                Style = "NormalTitle",
                ParagraphAlignment = PdfParagraphAlignmentType.Center
            });
            foreach (var order in info.Rooms.Rooms)
            {
                CreateRow(new PdfRowParameters
                {
                    Texts = new List<string> { order.Key,order.Value.ToString()
                },
                    Style = "Normal",
                    ParagraphAlignment = PdfParagraphAlignmentType.Left
                });
            }
            CreateParagraph(new PdfParagraph
            {
                Text = $"Оплачено за период: {info.Rooms.Sum}",
                Style = "Normal"
            });
            SavePdf(info);
        }
        protected abstract void CreatePdf(PdfInfo info);
        protected abstract void CreatePdf(PdfInfoRoom info);
        protected abstract void CreateParagraph(PdfParagraph paragraph);
        protected abstract void CreateTable(List<string> columns);
        protected abstract void CreateRow(PdfRowParameters rowParameters);
        protected abstract void SavePdf(PdfInfo info);
        protected abstract void SavePdf(PdfInfoRoom info);
    }
}
