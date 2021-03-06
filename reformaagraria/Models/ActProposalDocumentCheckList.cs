﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace reformaagraria.Models
{
    public class ActProposalDocumentCheckList
    {
        public ActProposalDocumentCheckList()
        {

        }

        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Region")]
        public int fkRegionId { get; set; }

        public bool ProposalFromCommunityList { get; set; }

        public bool ToraObjectList { get; set; }

        public bool ToraObjectMap { get; set; }

        public bool ToraSubjectList { get; set; }

        public bool ToraObjectForestAreaList { get; set; }

        public bool ToraObjectForestAreaMap { get; set; }

        public bool ToraSubjectForestAreaList { get; set; }

        public bool PsObjectAndCustomaryForestList { get; set; }

        public bool PsObjectAndCustomaryForestMap { get; set; }

        public bool PsSubjectAndCustomaryForestList { get; set; }

        public virtual Region Region { get; set; }

    }
}
