﻿namespace TSDMMusicdotNet.Models
{
    public class MoraJsonObjectModel
    {
        public string artistName { get; set; }
        public string artistNameKana { get; set; }
        public string artistNameNo { get; set; }
        public string artistNo { get; set; }
        public string bannerLinkUrl0 { get; set; }
        public object bannerLinkUrl1 { get; set; }
        public object bannerLinkUrl2 { get; set; }
        public object bannerLinkUrl3 { get; set; }
        public string bannerTargetBlank0 { get; set; }
        public object bannerTargetBlank1 { get; set; }
        public object bannerTargetBlank2 { get; set; }
        public object bannerTargetBlank3 { get; set; }
        public string bannerimage0 { get; set; }
        public object bannerimage1 { get; set; }
        public object bannerimage2 { get; set; }
        public object bannerimage3 { get; set; }
        public string bitPerSample { get; set; }
        public string callCoupon { get; set; }
        public string catchcopy { get; set; }
        public string cdPartNo { get; set; }
        public string channelConf { get; set; }
        public object comingSoon { get; set; }
        public string containCoupon { get; set; }
        public string couponProduct { get; set; }
        public string dispFlg { get; set; }
        public string dispStartDate { get; set; }
        public string dispStartDateStr { get; set; }
        public string displayLabelname { get; set; }
        public string distFlg { get; set; }
        public string distPartNo { get; set; }
        public object endDate { get; set; }
        public string fullsizeimage { get; set; }
        public string labelCode { get; set; }
        public string labelId { get; set; }
        public string labelcompanyname { get; set; }
        public string labelname { get; set; }
        public string listimage { get; set; }
        public string master { get; set; }
        public int materialNo { get; set; }
        public string mediaFlg { get; set; }
        public int mediaFormatNo { get; set; }
        public int mediaType { get; set; }
        public string metaDescription { get; set; }
        public string msin { get; set; }
        public string musicType { get; set; }
        public string packageComment { get; set; }
        public string packageId { get; set; }
        public string packageUrl { get; set; }
        public string packageimage { get; set; }
        public string prFlg { get; set; }
        public int price { get; set; }
        public int priceWithoutTax { get; set; }
        public int productTypeNo { get; set; }
        public object[] relatedPackage { get; set; }
        public int samplingFreq { get; set; }
        public string special { get; set; }
        public object specialPageUrl { get; set; }
        public string startDate { get; set; }
        public string tie { get; set; }
        public string title { get; set; }
        public string titleKana { get; set; }
        public Tracklist[] trackList { get; set; }
        public string weblistsizeimage { get; set; }
    }

    public class Tracklist
    {
        public string arranger { get; set; }
        public object arrangerKana { get; set; }
        public string artistName { get; set; }
        public string artistNameKana { get; set; }
        public int artistNameNo { get; set; }
        public int artistNo { get; set; }
        public string bitPerSample { get; set; }
        public string callCoupon { get; set; }
        public string channelConf { get; set; }
        public string composer { get; set; }
        public object composerKana { get; set; }
        public string couponProduct { get; set; }
        public string distFlg { get; set; }
        public string distPartNo { get; set; }
        public int duration { get; set; }
        public string durationStr { get; set; }
        public object endDate { get; set; }
        public string fullsizeimage { get; set; }
        public string labelCode { get; set; }
        public string labelId { get; set; }
        public string labelname { get; set; }
        public string listenDuration { get; set; }
        public string listenFlg { get; set; }
        public string listimage { get; set; }
        public string lyrics { get; set; }
        public object lyricsKana { get; set; }
        public string master { get; set; }
        public string materialNo { get; set; }
        public string mediaFlg { get; set; }
        public string mediaFormatNo { get; set; }
        public string mediaType { get; set; }
        public string msin { get; set; }
        public object musicComment { get; set; }
        public string musicId { get; set; }
        public string packageimage { get; set; }
        public string prFlg { get; set; }
        public string price { get; set; }
        public string priceWithoutTax { get; set; }
        public object producer { get; set; }
        public object producerKana { get; set; }
        public string productTypeNo { get; set; }
        public string samplingFreq { get; set; }
        public string specialPageUrl { get; set; }
        public string startDate { get; set; }
        public string tid { get; set; }
        public object tie { get; set; }
        public object tieType { get; set; }
        public string title { get; set; }
        public string titleKana { get; set; }
        public string trackNo { get; set; }
        public string weblistsizeimage { get; set; }
    }
}