using ELibrary.Infrastructure.Data.Models;
using ELibrary.Infrastructure.Data.Types;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELibrary.Infrastructure.Data.Configurations
{
    public class ResourceTypeConfiguration : IEntityTypeConfiguration<Resource>
    {
        public void Configure(EntityTypeBuilder<Resource> builder)
        {
            var uploadedOn = DateTime.UtcNow;
            builder.HasData(
                new Resource
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "Introduction to Algebra",
                    Subject = "Mathematics",
                    Description = "Basic algebra concepts for beginners.",
                    Type = ResourceType.PDF,
                    CoverImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTu5dP-doCEi_ENZ0MohLSohexccNWBwwYlVg&s",
                    UploadedOn = uploadedOn
                },
                new Resource
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "World History Overview",
                    Subject = "History",
                    Description = "A timeline of major world history events.",
                    Type = ResourceType.PDF,
                    CoverImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTAhAgn6PoF2RrL0mTnTVKq4DXHrbIKd5G20w&s",
                    UploadedOn = uploadedOn
                },
                new Resource
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "Photosynthesis Explained",
                    Subject = "Biology",
                    Description = "Short video explaining photosynthesis process.",
                    Type = ResourceType.Video,
                    CoverImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR-z4VBEey9QK4XPYMXK3lkFI9zec7AVUM8sg&s",
                    UploadedOn = uploadedOn
                },
                new Resource
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "Newton's Laws of Motion",
                    Subject = "Physics",
                    Description = "An overview of Newton's three laws of motion.",
                    Type = ResourceType.PDF,
                    CoverImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQHRGvbwPxrbxNYWyGFtHsuTPtrEwVJWDJf4A&s",
                    UploadedOn = uploadedOn
                },
                new Resource
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "Learn French Basics",
                    Subject = "Languages",
                    Description = "Video lessons for basic French vocabulary.",
                    Type = ResourceType.Video,
                    CoverImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT7YTHf1DDxgEYh5S8wRH9rPYj4gHwTGf1GTQ&s",
                    UploadedOn = uploadedOn
                },
                new Resource
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "Periodic Table Reference",
                    Subject = "Chemistry",
                    Description = "Reference guide to elements in the periodic table.",
                    Type = ResourceType.PDF,
                    CoverImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSraYINVd1T85796jgxTNZkOsdIFgB9kwx2rw&s",
                    UploadedOn = uploadedOn
                },
                new Resource
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "Introduction to Programming",
                    Subject = "Computer Science",
                    Description = "Beginner-friendly programming concepts.",
                    Type = ResourceType.PDF,
                    CoverImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSWshjlQbu3zszK0jh2L_TwIc5Sm81KaSp63A&s",
                    UploadedOn = uploadedOn
                },
                new Resource
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "Climate Change and Its Impact",
                    Subject = "Environmental Science",
                    Description = "Article about global warming and its effects.",
                    Type = ResourceType.Link,
                    CoverImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTwMtF9HZNRaZHdTiKVcfPAo37lZXoUD0eOMQ&s",
                    UploadedOn = uploadedOn
                },
                new Resource
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "Basic Geometry Shapes",
                    Subject = "Mathematics",
                    Description = "PDF guide to understanding geometric shapes.",
                    Type = ResourceType.PDF,
                    CoverImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTQ2_Bw8irY9VYn2pk5r9LcjSfopOg01evB3w&s",
                    UploadedOn = uploadedOn
                },
                new Resource
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "Introduction to Economics",
                    Subject = "Economics",
                    Description = "Video lecture explaining supply and demand.",
                    Type = ResourceType.Video,
                    CoverImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQWLOImHrZv1Gi5dPoLPOa7YnPaYDgAvf6tfA&s",
                    UploadedOn = uploadedOn
                }
            );
        }
    }
}
