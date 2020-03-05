using EventConference.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventConference.Entities.Configuration
{
    public class FaqConfiguration : IEntityTypeConfiguration<Faq>
    {
        public void Configure(EntityTypeBuilder<Faq> builder)
        {
            builder.Property(p => p.CreatedAt).HasDefaultValue(DateTime.Now);
            builder.Property(p => p.UpdatedAt).HasDefaultValue(DateTime.Now);

            var faqs = new List<Faq> { 
                new Faq
                {
                    Id=1,
                    Question="Unde a ut eligendi dolor ducimus.",
                    Answer="Aut sequi aliquam deleniti. Dolore rerum aliquid maiores velit laudantium nam. Perspiciatis dignissimos culpa non et natus laboriosam. Quisquam eos eveniet et facere."
                },
                new Faq
                {
                    Id=2,
                    Question="Sint deleniti dolorem enim ipsum.	",
                    Answer="Est et occaecati asperiores natus. Quia aut velit omnis. Fugiat necessitatibus natus quo ratione in voluptas minus quam. Quia et quam autem est aut et."
                },
                new Faq
                {
                    Id=3,
                    Question="Provident sit tempore blanditiis et aut est.",
                    Answer="Corrupti qui ad dolorem quos quod quaerat. Dolorem adipisci in sint doloremque eum ut ut. Fuga eos quod qui optio illum. Et totam officiis culpa."
                },
                new Faq
                {
                    Id=4,
                    Question="Dolorem dolores iusto accusamus qui illum qui ipsum.",
                    Answer="Occaecati doloremque aut nulla ut ut repudiandae. Quam sed saepe omnis sit."
                },
                new Faq
                {
                    Id=5,
                    Question="Voluptatem culpa odit repudiandae at omnis magni.",
                    Answer="Est sit sint modi fugit a voluptate. Incidunt qui impedit blanditiis sint animi nobis. Esse mollitia autem sunt quia aliquid."
                },
                new Faq
                {
                    Id=6,
                    Question="Occaecati a et sapiente et veritatis sunt ea.",
                    Answer="Enim qui fuga aliquid et recusandae porro ipsam. Praesentium molestiae qui nisi illum praesentium quia accusamus dolores. Ut aut sed magnam sit dolorum dolores nesciunt."
                }
            };

            builder.HasData(faqs);
        }
    }
}
