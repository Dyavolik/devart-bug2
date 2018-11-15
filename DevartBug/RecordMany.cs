using System.ComponentModel.DataAnnotations.Schema;

namespace DevartBug
{
	[Table("record_many")]
	public class RecordMany
	{
		[Column("id")]
		public int Id { get; set; }

		[Column("record_one_id")]
		[ForeignKey("RecordOne")]
		public int RecordOneId { get; set; }

		public RecordOne RecordOne { get; set; }
	}
}