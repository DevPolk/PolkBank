using Infrastructure.Entities;
using Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistence.Repositories
{
    public class NewsRepository : INewsRepository
    {
        public News GetById(int id) => News.SingleOrDefault(n => n.Id == id) ?? throw new Exception($"News with Id {id} not found.");

        public IEnumerable<News> GetNews(int pageIndex = 1, int pageSize = 3) => News.Skip((pageIndex - 1) * pageSize).Take(pageSize);

        public int GetCount() => News.Count;

        private readonly ICollection<News> News = new HashSet<News>()
        {
            new News()
            {
                Content = @"Lorem ipsum is a pseudo-Latin text used in web design, typography, layout, and printing 
                            in place of English to emphasise design elements over content. It's also called placeholder (or filler) 
                            text. It's a convenient tool for mock-ups. It helps to outline the visual elements of a document or 
                            presentation, eg typography, font, or layout. Lorem ipsum is mostly a part of a Latin text by the classical 
                            author and philosopher Cicero. Its words and letters have been changed by addition or removal, so to deliberately 
                            render its content nonsensical; it's not genuine, correct, or comprehensible Latin anymore. ",
                 ImageUrl = "https://expert.ru/data/public/480967/480974/16.jpg",
                 Title = "Новость 1",
                 Id = 1
            },
            new News()
            {
                Content = @"Lorem ipsum dolor sit amet, ludus neglegentur ne nec, vix mutat dicam ea. Mei ut posse tollit scripserit, 
                            quis paulo ignota sea eu. Vix te noster facete omnium. Eos ut alii dicam labore, sit mandamus repudiare definiebas in. 
                            At vix forensibus reformidans. Alii persius eam eu.",
                 ImageUrl = "http://www.klaipeda1945.org/wp-content/uploads/2018/02/26.02.2018-Latviya-wefced.jpg",
                 Title = "Новость 2",
                 Id = 2
            },
            new News()
            {
                Content = @"Lorem ipsum is a pseudo-Latin text used in web design, typography, layout, and printing 
                            in place of English to emphasise design elements over content. It's also called placeholder (or filler) 
                            text. It's a convenient tool for mock-ups. It helps to outline the visual elements of a document or 
                            presentation, eg typography, font, or layout. Lorem ipsum is mostly a part of a Latin text by the classical 
                            author and philosopher Cicero. Its words and letters have been changed by addition or removal, so to deliberately 
                            render its content nonsensical; it's not genuine, correct, or comprehensible Latin anymore. ",
                 ImageUrl = "https://cdn21.img.ria.ru/images/151791/06/1517910666_0:160:3076:1890_600x0_80_0_0_280d6d148a0780ba6e50256e4e88e8b2.jpg",
                 Title = "Новость 3",
                 Id = 3
            },
            new News()
            {
                Content = @"Lorem ipsum dolor sit amet, ludus neglegentur ne nec, vix mutat dicam ea. Mei ut posse tollit scripserit, 
                            quis paulo ignota sea eu. Vix te noster facete omnium. Eos ut alii dicam labore, sit mandamus repudiare definiebas in. 
                            At vix forensibus reformidans. Alii persius eam eu.",
                 ImageUrl = "https://moe-online.ru/media/7/2/3/3/6/7/material_1025850/original_photo-thumb_1920.jpg",
                 Title = "Новость 4",
                 Id = 4
            },
            new News()
            {
                Content = @"Lorem ipsum is a pseudo-Latin text used in web design, typography, layout, and printing 
                            in place of English to emphasise design elements over content. It's also called placeholder (or filler) 
                            text. It's a convenient tool for mock-ups. It helps to outline the visual elements of a document or 
                            presentation, eg typography, font, or layout. Lorem ipsum is mostly a part of a Latin text by the classical 
                            author and philosopher Cicero. Its words and letters have been changed by addition or removal, so to deliberately 
                            render its content nonsensical; it's not genuine, correct, or comprehensible Latin anymore. ",
                 ImageUrl = "https://f.sravni.ru/cms/KnowledgeBaseArticle/Picture/mat_61925.jpg",
                 Title = "Новость 5",
                 Id = 5
            }
        };
    }
}
