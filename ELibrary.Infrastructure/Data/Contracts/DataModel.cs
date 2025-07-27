using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ELibrary.Infrastructure.Data.Contracts
{
    /// <summary>
    /// Represents an abstract base class for data models that supports 
    /// auditing and soft deletion functionality.
    /// </summary>
    /// <remarks>
    /// Implements <see cref="IAuditable"/> and <see cref="IDeletable"/> interfaces.
    /// </remarks>
    public abstract class DataModel : IAuditable, IDeletable
    {
        /// <summary>
        /// Gets or sets the unique identifier for the data model record.
        /// </summary>
        [Key]
        [Comment("Gets or sets the unique identifier for the data model record.")]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// Gets or sets a value indicating whether the record has been marked as deleted.
        /// </summary>
        [Comment("Gets or sets a value indicating whether the record has been marked as deleted.")]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the record was marked as deleted.
        /// </summary>
        [DataType(DataType.DateTime)]
        [Comment("Gets or sets the date and time when the record was marked as deleted..")]
        public DateTime? DeletedOn { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the record was created.
        /// </summary>
        [DataType(DataType.DateTime)]
        [Comment("Gets or sets the date and time when the record was created.")]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the record was last modified.
        /// </summary>
        [DataType(DataType.DateTime)]
        [Comment("Gets or sets the date and time when the record was last modified.")]
        public DateTime? LastModifiedOn { get; set; }
    }
}
