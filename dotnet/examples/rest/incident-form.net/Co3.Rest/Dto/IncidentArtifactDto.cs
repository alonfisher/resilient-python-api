﻿/*
 * Resilient Systems, Inc. ("Resilient") is willing to license software
 * or access to software to the company or entity that will be using or
 * accessing the software and documentation and that you represent as
 * an employee or authorized agent ("you" or "your") only on the condition
 * that you accept all of the terms of this license agreement.
 *
 * The software and documentation within Resilient's Development Kit are
 * copyrighted by and contain confidential information of Resilient. By
 * accessing and/or using this software and documentation, you agree that
 * while you may make derivative works of them, you:
 *
 * 1)  will not use the software and documentation or any derivative
 *     works for anything but your internal business purposes in
 *     conjunction your licensed used of Resilient's software, nor
 * 2)  provide or disclose the software and documentation or any
 *     derivative works to any third party.
 *
 * THIS SOFTWARE AND DOCUMENTATION IS PROVIDED "AS IS" AND ANY EXPRESS
 * OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
 * ARE DISCLAIMED. IN NO EVENT SHALL RESILIENT BE LIABLE FOR ANY DIRECT,
 * INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
 * (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)
 * HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT,
 * STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
 * ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED
 * OF THE POSSIBILITY OF SUCH DAMAGE.
 */

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Co3.Rest.Dto
{
    public class IncidentArtifactDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public ObjectHandle Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("description")]
        public TextContentDto Description { get; set; }

        [JsonProperty("creator")]
        public JustUserDto Creator { get; set; }

        [JsonProperty("hits")]
        public List<ThreatHitDto> Hits { get; set; }

        [JsonProperty("attachment")]
        public AttachmentDto Attachment { get; set; }

        [JsonProperty("parent_id")]
        public int ParentId { get; set; }

        [JsonProperty("inc_id")]
        public int IncId { get; set; }

        [JsonProperty("inc_name")]
        public string IncName { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("pending_sources")]
        public List<ObjectHandle> PendingSources { get; set; }

        [JsonProperty("perms")]
        public IncidentArtifactPermsDto Perms { get; set; }

        [JsonProperty("properties")]
        public List<IncidentArtifactPropertyDto> Properties { get; set; }

        [JsonProperty("location")]
        public IncidentArtifactLocationDto Location { get; set; }

        [JsonProperty("whois")]
        public WhoisDto Whois { get; set; }

        [JsonProperty("actions")]
        public List<ActionInfoDto> Actions { get; set; }
    }
}