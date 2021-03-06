﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingFramework.Core.Base;
using TelerikSystem.Core.Admin.BasicModules.Pages.DynamicPages.CreateDynamicPage;
using TestingFramework.Core.Models;
using TelerikSystem.Core.Pages.LoginPage;
using TelerikSystem.Core.Admin.BasicModules.Pages.DynamicPages.DynamicPages;
using TelerikSystem.Core.Admin.SoftwareAcademy.Pages.Seasons.CreateNewSeason;
using TelerikSystem.Core.Admin.SoftwareAcademy.Pages.Seasons.SeasonsMainPage;
// using NUnit.Framework;

namespace TelerikSystem.Tests.Admin.SoftwareAcademy.Seasons
{
    [TestClass]
    public class SeasonsPagesTest : BaseTest
    {
        private TestingFramework.Core.Models.User currentUser;

        public override void TestInit()
        {
            this.currentUser = GetUser.Admin();
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<MainPageSeasonPage>.Instance.Navigate();
            
        }

        //[TestMethod]
        //[Owner("Violeta Roumenova")]
        //[Priority(2)]
        //public void SeasonPages_AssertPageIsCreated()
        //{
        //    Pages<MainPageSeasonPage>.Instance.();
        //}

        //[TestMethod] 
        //[Owner("Violeta Roumenova")]
        //[Priority(2)]
        //public void SeasonPages_AssertPageIsNotCreated()
        //{
        //    Pages<DynamicPagesPageValidator>.Instance.VerifyDynamicPageIsNotCreated();
        //}

        //[TestMethod]
        //[Owner("Violeta Roumenova")]
        //[Priority(2)]
        //public void SeasonPages_AssertPageIsDeleted()
        //{
        //    Pages<DynamicPagesPageValidator>.Instance.VerifyDynamicPageIsDeleted();
        //}

        #region[title]
        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(4)]
   //     [TestCase(396)]
        public void SeasonPages_AssertTitleLocalErrorIsVisible_Null()
        {
            Pages<MainPageSeasonPage>.Instance.Map.CreateSeason.Click(); // FIRECLICK!!!!!!!!!!!!!!!!!
            Pages<CreateNewSeasonPageValidator>.Instance.VerifyErrorMessageTitleIsVisible_NullTitle();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(4)]
     //   [TestCase(397)]
        public void SeasonPages_AssertTitleLocalErrorIsVisible_EmptyStringTitle()
        {
            Pages<MainPageSeasonPage>.Instance.Map.CreateSeason.Click(); // FIRECLICK!!!!!!!!!!!!!!!!!
            Pages<CreateNewSeasonPageValidator>.Instance.VerifyErrorMessageTitleIsVisible_EmptyTitle();
        }


        [TestMethod] // bug
        [Owner("Violeta Roumenova")]
        [Priority(4)]
     //   [TestCase(398)]
        public void SeasonPages_AssertTitleLocalErrorIsVisible_WhiteSpace()
        {
            Pages<MainPageSeasonPage>.Instance.Map.CreateSeason.Click(); // FIRECLICK!!!!!!!!!!!!!!!!!
            Pages<CreateNewSeasonPageValidator>.Instance.VerifyErrorMessageTitleIsVisible_WhiteSpaceTitle();
        }

        [TestMethod] // bug
        [Owner("Violeta Roumenova")]
        [Priority(4)]
      //  [TestCase(399)]
        public void SeasonPages_AssertTitleLocalErrorIsVisible_TitleLength2symbols()
        {
            Pages<MainPageSeasonPage>.Instance.Map.CreateSeason.Click(); // FIRECLICK!!!!!!!!!!!!!!!!!
            Pages<CreateNewSeasonPageValidator>.Instance.VerifyErrorMessageTitleIsVisible_TitleLength2symbols();
        }

        [TestMethod] // bug created with no name
        [Owner("Violeta Roumenova")]
        [Priority(4)]
      //  [TestCase(400)]
        public void SeasonPages_AssertTitleLocalErrorIsVisible_TitleLength201symbols()
        {
            Pages<MainPageSeasonPage>.Instance.Map.CreateSeason.Click(); // FIRECLICK!!!!!!!!!!!!!!!!!
            Pages<CreateNewSeasonPageValidator>.Instance.VerifyErrorMessageTitleIsVisible_TitleLength201symbols();
        }

        #endregion
    }
}
