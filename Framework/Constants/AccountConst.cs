﻿/*
 * Copyright (C) 2012-2017 CypherCore <http://github.com/CypherCore>
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace Framework.Constants
{
    public enum AccountDataTypes
    {
        GlobalConfigCache = 0x00,
        PerCharacterConfigCache = 0x01,
        GlobalBindingsCache = 0x02,
        PerCharacterBindingsCache = 0x03,
        GlobalMacrosCache = 0x04,
        PerCharacterMacrosCache = 0x05,
        PerCharacterLayoutCache = 0x06,
        PerCharacterChatCache = 0x07,
        Max = 8,

        GlobalCacheMask = 0x15,
        PerCharacterCacheMask = 0xEA
    }

    public enum TutorialAction
    {
        Update = 0,
        Clear = 1,
        Reset = 2
    }

    public enum AccountTypes
    {
        Player = 0,
        Moderator = 1,
        GameMaster = 2,
        Administrator = 3,
        Console = 4
    }

    public enum RBACPermissions
    {
        None = 0,
        InstantLogout = 1,
        SkipQueue = 2,
        JoinNormalBg = 3,
        JoinRandomBg = 4,
        JoinArenas = 5,
        JoinDungeonFinder = 6,
        //  7 - Reuse
        //  8 - Reuse
        //  9 - Reuse
        UseCharacterTemplates = 10,
        LogGmTrade = 11,
        SkipCheckCharacterCreationDemonHunter = 12,
        SkipCheckInstanceRequiredBosses = 13,
        SkipCheckCharacterCreationTeammask = 14,
        SkipCheckCharacterCreationClassmask = 15,
        SkipCheckCharacterCreationRacemask = 16,
        SkipCheckCharacterCreationReservedname = 17,
        SkipCheckCharacterCreationDeathKnight = 18,
        SkipCheckChatChannelReq = 19,
        SkipCheckDisableMap = 20,
        SkipCheckMoreTalentsThanAllowed = 21,
        SkipCheckChatSpam = 22,
        SkipCheckOverspeedPing = 23,
        TwoSideCharacterCreation = 24,
        TwoSideInteractionChat = 25,
        TwoSideInteractionChannel = 26,
        TwoSideInteractionMail = 27,
        TwoSideWhoList = 28,
        TwoSideAddFriend = 29,
        CommandsSaveWithoutDelay = 30,
        CommandsUseUnstuckWithArgs = 31,
        CommandsBeAssignedTicket = 32,
        CommandsNotifyCommandNotFoundError = 33,
        CommandsAppearInGmList = 34,
        WhoSeeAllSecLevels = 35,
        CanFilterWhispers = 36,
        ChatUseStaffBadge = 37,
        ResurrectWithFullHps = 38,
        RestoreSavedGmState = 39,
        AllowGmFriend = 40,
        UseStartGmLevel = 41,
        OpcodeWorldTeleport = 42,
        OpcodeWhois = 43,
        ReceiveGlobalGmTextmessage = 44,
        SilentlyJoinChannel = 45,
        ChangeChannelNotModerator = 46,
        CheckForLowerSecurity = 47,
        CommandsPinfoCheckPersonalData = 48,
        EmailConfirmForPassChange = 49,
        MayCheckOwnEmail = 50,
        AllowTwoSideTrade = 51,

        // Free Space For Core Permissions (Till 149)
        // Roles (Permissions With Delegated Permissions) Use 199 And Descending
        CommandRbac = 200,
        CommandRbacAcc = 201,
        CommandRbacAccPermList = 202,
        CommandRbacAccPermGrant = 203,
        CommandRbacAccPermDeny = 204,
        CommandRbacAccPermRevoke = 205,
        CommandRbacList = 206,
        CommandBnetAccount = 207,
        CommandBnetAccountCreate = 208,
        CommandBnetAccountLockCountry = 209,
        CommandBnetAccountLockIp = 210,
        CommandBnetAccountPassword = 211,
        CommandBnetAccountSet = 212,
        CommandBnetAccountSetPassword = 213,
        CommandBnetAccountLink = 214,
        CommandBnetAccountUnlink = 215,
        CommandBnetAccountCreateGame = 216,
        CommandAccount = 217,
        CommandAccountAddon = 218,
        CommandAccountCreate = 219,
        CommandAccountDelete = 220,
        CommandAccountLock = 221,
        CommandAccountLockCountry = 222,
        CommandAccountLockIp = 223,
        CommandAccountOnlineList = 224,
        CommandAccountPassword = 225,
        CommandAccountSet = 226,
        CommandAccountSetAddon = 227,
        CommandAccountSetGmlevel = 228,
        CommandAccountSetPassword = 229,
        CommandAchievement = 230,
        CommandAchievementAdd = 231,
        CommandArena = 232,
        CommandArenaCaptain = 233,
        CommandArenaCreate = 234,
        CommandArenaDisband = 235,
        CommandArenaInfo = 236,
        CommandArenaLookup = 237,
        CommandArenaRename = 238,
        CommandBan = 239,
        CommandBanAccount = 240,
        CommandBanCharacter = 241,
        CommandBanIp = 242,
        CommandBanPlayeraccount = 243,
        CommandBaninfo = 244,
        CommandBaninfoAccount = 245,
        CommandBaninfoCharacter = 246,
        CommandBaninfoIp = 247,
        CommandBanlist = 248,
        CommandBanlistAccount = 249,
        CommandBanlistCharacter = 250,
        CommandBanlistIp = 251,
        CommandUnban = 252,
        CommandUnbanAccount = 253,
        CommandUnbanCharacter = 254,
        CommandUnbanIp = 255,
        CommandUnbanPlayeraccount = 256,
        CommandBf = 257,
        CommandBfStart = 258,
        CommandBfStop = 259,
        CommandBfSwitch = 260,
        CommandBfTimer = 261,
        CommandBfEnable = 262,
        CommandAccountEmail = 263,
        CommandAccountSetSec = 264,
        CommandAccountSetSecEmail = 265,
        CommandAccountSetSecRegmail = 266,
        CommandCast = 267,
        CommandCastBack = 268,
        CommandCastDist = 269,
        CommandCastSelf = 270,
        CommandCastTarget = 271,
        CommandCastDest = 272,
        CommandCharacter = 273,
        CommandCharacterCustomize = 274,
        CommandCharacterChangefaction = 275,
        CommandCharacterChangerace = 276,
        CommandCharacterDeleted = 277,
        CommandCharacterDeletedDelete = 278,
        CommandCharacterDeletedList = 279,
        CommandCharacterDeletedRestore = 280,
        CommandCharacterDeletedOld = 281,
        CommandCharacterErase = 282,
        CommandCharacterLevel = 283,
        CommandCharacterRename = 284,
        CommandCharacterReputation = 285,
        CommandCharacterTitles = 286,
        CommandLevelup = 287,
        CommandPdump = 288,
        CommandPdumpLoad = 289,
        CommandPdumpWrite = 290,
        CommandCheat = 291,
        CommandCheatCasttime = 292,
        CommandCheatCooldown = 293,
        CommandCheatExplore = 294,
        CommandCheatGod = 295,
        CommandCheatPower = 296,
        CommandCheatStatus = 297,
        CommandCheatTaxi = 298,
        CommandCheatWaterwalk = 299,
        CommandDebug = 300,
        CommandDebugAnim = 301,
        CommandDebugAreatriggers = 302,
        CommandDebugArena = 303,
        CommandDebugBg = 304,
        CommandDebugEntervehicle = 305,
        CommandDebugGetitemstate = 306,
        CommandDebugGetitemvalue = 307,
        CommandDebugGetvalue = 308,
        CommandDebugHostil = 309,
        CommandDebugItemexpire = 310,
        CommandDebugLootrecipient = 311,
        CommandDebugLos = 312,
        CommandDebugMod32value = 313,
        CommandDebugMoveflags = 314,
        CommandDebugPlay = 315,
        CommandDebugPlayCinematic = 316,
        CommandDebugPlayMovie = 317,
        CommandDebugPlaySound = 318,
        CommandDebugSend = 319,
        CommandDebugSendBuyerror = 320,
        CommandDebugSendChannelnotify = 321,
        CommandDebugSendChatmessage = 322,
        CommandDebugSendEquiperror = 323,
        CommandDebugSendLargepacket = 324,
        CommandDebugSendOpcode = 325,
        CommandDebugSendQinvalidmsg = 326,
        CommandDebugSendQpartymsg = 327,
        CommandDebugSendSellerror = 328,
        CommandDebugSendSetphaseshift = 329,
        CommandDebugSendSpellfail = 330,
        CommandDebugSetaurastate = 331,
        CommandDebugSetbit = 332,
        CommandDebugSetitemvalue = 333,
        CommandDebugSetvalue = 334,
        CommandDebugSetvid = 335,
        CommandDebugSpawnvehicle = 336,
        CommandDebugThreat = 337,
        CommandDebugUpdate = 338,
        CommandDebugUws = 339,
        CommandWpgps = 340,
        CommandDeserter = 341,
        CommandDeserterBg = 342,
        CommandDeserterBgAdd = 343,
        CommandDeserterBgRemove = 344,
        CommandDeserterInstance = 345,
        CommandDeserterInstanceAdd = 346,
        CommandDeserterInstanceRemove = 347,
        CommandDisable = 348,
        CommandDisableAdd = 349,
        CommandDisableAddCriteria = 350,
        CommandDisableAddBattleground = 351,
        CommandDisableAddMap = 352,
        CommandDisableAddMmap = 353,
        CommandDisableAddOutdoorpvp = 354,
        CommandDisableAddQuest = 355,
        CommandDisableAddSpell = 356,
        CommandDisableAddVmap = 357,
        CommandDisableRemove = 358,
        CommandDisableRemoveCriteria = 359,
        CommandDisableRemoveBattleground = 360,
        CommandDisableRemoveMap = 361,
        CommandDisableRemoveMmap = 362,
        CommandDisableRemoveOutdoorpvp = 363,
        CommandDisableRemoveQuest = 364,
        CommandDisableRemoveSpell = 365,
        CommandDisableRemoveVmap = 366,
        CommandEvent = 367,
        CommandEventActivelist = 368,
        CommandEventStart = 369,
        CommandEventStop = 370,
        CommandGm = 371,
        CommandGmChat = 372,
        CommandGmFly = 373,
        CommandGmIngame = 374,
        CommandGmList = 375,
        CommandGmVisible = 376,
        CommandGo = 377,
        CommandGoCreature = 378,
        CommandGoGraveyard = 379,
        CommandGoGrid = 380,
        CommandGoObject = 381,
        CommandGoTaxinode = 382,
        // 383 reuse
        CommandGoTrigger = 384,
        CommandGoXyz = 385,
        CommandGoZonexy = 386,
        CommandGobject = 387,
        CommandGobjectActivate = 388,
        CommandGobjectAdd = 389,
        CommandGobjectAddTemp = 390,
        CommandGobjectDelete = 391,
        CommandGobjectInfo = 392,
        CommandGobjectMove = 393,
        CommandGobjectNear = 394,
        CommandGobjectSet = 395,
        CommandGobjectSetPhase = 396,
        CommandGobjectSetState = 397,
        CommandGobjectTarget = 398,
        CommandGobjectTurn = 399,
        CommandDebugTransport = 400,
        CommandGuild = 401,
        CommandGuildCreate = 402,
        CommandGuildDelete = 403,
        CommandGuildInvite = 404,
        CommandGuildUninvite = 405,
        CommandGuildRank = 406,
        CommandGuildRename = 407,
        CommandHonor = 408,
        CommandHonorAdd = 409,
        CommandHonorAddKill = 410,
        CommandHonorUpdate = 411,
        CommandInstance = 412,
        CommandInstanceListbinds = 413,
        CommandInstanceUnbind = 414,
        CommandInstanceStats = 415,
        CommandInstanceSavedata = 416,
        CommandLearn = 417,
        CommandLearnAll = 418,
        CommandLearnAllMy = 419,
        CommandLearnAllMyClass = 420,
        CommandLearnAllMyPettalents = 421,
        CommandLearnAllMySpells = 422,
        CommandLearnAllMyTalents = 423,
        CommandLearnAllGm = 424,
        CommandLearnAllCrafts = 425,
        CommandLearnAllDefault = 426,
        CommandLearnAllLang = 427,
        CommandLearnAllRecipes = 428,
        CommandUnlearn = 429,
        CommandLfg = 430,
        CommandLfgPlayer = 431,
        CommandLfgGroup = 432,
        CommandLfgQueue = 433,
        CommandLfgClean = 434,
        CommandLfgOptions = 435,
        CommandList = 436,
        CommandListCreature = 437,
        CommandListItem = 438,
        CommandListObject = 439,
        CommandListAuras = 440,
        CommandListMail = 441,
        CommandLookup = 442,
        CommandLookupArea = 443,
        CommandLookupCreature = 444,
        CommandLookupEvent = 445,
        CommandLookupFaction = 446,
        CommandLookupItem = 447,
        CommandLookupItemset = 448,
        CommandLookupObject = 449,
        CommandLookupQuest = 450,
        CommandLookupPlayer = 451,
        CommandLookupPlayerIp = 452,
        CommandLookupPlayerAccount = 453,
        CommandLookupPlayerEmail = 454,
        CommandLookupSkill = 455,
        CommandLookupSpell = 456,
        CommandLookupSpellId = 457,
        CommandLookupTaxinode = 458,
        CommandLookupTele = 459,
        CommandLookupTitle = 460,
        CommandLookupMap = 461,
        CommandAnnounce = 462,
        CommandChannel = 463,
        CommandChannelSet = 464,
        CommandChannelSetOwnership = 465,
        CommandGmannounce = 466,
        CommandGmnameannounce = 467,
        CommandGmnotify = 468,
        CommandNameannounce = 469,
        CommandNotify = 470,
        CommandWhispers = 471,
        CommandGroup = 472,
        CommandGroupLeader = 473,
        CommandGroupDisband = 474,
        CommandGroupRemove = 475,
        CommandGroupJoin = 476,
        CommandGroupList = 477,
        CommandGroupSummon = 478,
        CommandPet = 479,
        CommandPetCreate = 480,
        CommandPetLearn = 481,
        CommandPetUnlearn = 482,
        CommandSend = 483,
        CommandSendItems = 484,
        CommandSendMail = 485,
        CommandSendMessage = 486,
        CommandSendMoney = 487,
        CommandAdditem = 488,
        CommandAdditemset = 489,
        CommandAppear = 490,
        CommandAura = 491,
        CommandBank = 492,
        CommandBindsight = 493,
        CommandCombatstop = 494,
        CommandCometome = 495,
        CommandCommands = 496,
        CommandCooldown = 497,
        CommandDamage = 498,
        CommandDev = 499,
        CommandDie = 500,
        CommandDismount = 501,
        CommandDistance = 502,
        CommandFlusharenapoints = 503,
        CommandFreeze = 504,
        CommandGps = 505,
        CommandGuid = 506,
        CommandHelp = 507,
        CommandHidearea = 508,
        CommandItemmove = 509,
        CommandKick = 510,
        CommandLinkgrave = 511,
        CommandListfreeze = 512,
        CommandMaxskill = 513,
        CommandMovegens = 514,
        CommandMute = 515,
        CommandNeargrave = 516,
        CommandPinfo = 517,
        CommandPlayall = 518,
        CommandPossess = 519,
        CommandRecall = 520,
        CommandRepairitems = 521,
        CommandRespawn = 522,
        CommandRevive = 523,
        CommandSaveall = 524,
        CommandSave = 525,
        CommandSetskill = 526,
        CommandShowarea = 527,
        CommandSummon = 528,
        CommandUnaura = 529,
        CommandUnbindsight = 530,
        CommandUnfreeze = 531,
        CommandUnmute = 532,
        CommandUnpossess = 533,
        CommandUnstuck = 534,
        CommandWchange = 535,
        CommandMmap = 536,
        CommandMmapLoadedtiles = 537,
        CommandMmapLoc = 538,
        CommandMmapPath = 539,
        CommandMmapStats = 540,
        CommandMmapTestarea = 541,
        CommandMorph = 542,
        CommandDemorph = 543,
        CommandModify = 544,
        CommandModifyArenapoints = 545,
        CommandModifyBit = 546,
        CommandModifyDrunk = 547,
        CommandModifyEnergy = 548,
        CommandModifyFaction = 549,
        CommandModifyGender = 550,
        CommandModifyHonor = 551,
        CommandModifyHp = 552,
        CommandModifyMana = 553,
        CommandModifyMoney = 554,
        CommandModifyMount = 555,
        CommandModifyPhase = 556,
        CommandModifyRage = 557,
        CommandModifyReputation = 558,
        CommandModifyRunicpower = 559,
        CommandModifyScale = 560,
        CommandModifySpeed = 561,
        CommandModifySpeedAll = 562,
        CommandModifySpeedBackwalk = 563,
        CommandModifySpeedFly = 564,
        CommandModifySpeedWalk = 565,
        CommandModifySpeedSwim = 566,
        CommandModifySpell = 567,
        CommandModifyStandstate = 568,
        CommandModifyTalentpoints = 569,
        CommandNpc = 570,
        CommandNpcAdd = 571,
        CommandNpcAddFormation = 572,
        CommandNpcAddItem = 573,
        CommandNpcAddMove = 574,
        CommandNpcAddTemp = 575,
        CommandNpcDelete = 576,
        CommandNpcDeleteItem = 577,
        CommandNpcFollow = 578,
        CommandNpcFollowStop = 579,
        CommandNpcSet = 580,
        CommandNpcSetAllowmove = 581,
        CommandNpcSetEntry = 582,
        CommandNpcSetFactionid = 583,
        CommandNpcSetFlag = 584,
        CommandNpcSetLevel = 585,
        CommandNpcSetLink = 586,
        CommandNpcSetModel = 587,
        CommandNpcSetMovetype = 588,
        CommandNpcSetPhase = 589,
        CommandNpcSetSpawndist = 590,
        CommandNpcSetSpawntime = 591,
        CommandNpcSetData = 592,
        CommandNpcInfo = 593,
        CommandNpcNear = 594,
        CommandNpcMove = 595,
        CommandNpcPlayemote = 596,
        CommandNpcSay = 597,
        CommandNpcTextemote = 598,
        CommandNpcWhisper = 599,
        CommandNpcYell = 600,
        CommandNpcTame = 601,
        CommandQuest = 602,
        CommandQuestAdd = 603,
        CommandQuestComplete = 604,
        CommandQuestRemove = 605,
        CommandQuestReward = 606,
        CommandReload = 607,
        CommandReloadAccessRequirement = 608,
        CommandReloadCriteriaData = 609,
        CommandReloadAchievementReward = 610,
        CommandReloadAll = 611,
        CommandReloadAllAchievement = 612,
        CommandReloadAllArea = 613,
        CommandReloadBroadcastText = 614,
        CommandReloadAllGossip = 615,
        CommandReloadAllItem = 616,
        CommandReloadAllLocales = 617,
        CommandReloadAllLoot = 618,
        CommandReloadAllNpc = 619,
        CommandReloadAllQuest = 620,
        CommandReloadAllScripts = 621,
        CommandReloadAllSpell = 622,
        CommandReloadAreatriggerInvolvedrelation = 623,
        CommandReloadAreatriggerTavern = 624,
        CommandReloadAreatriggerTeleport = 625,
        CommandReloadAuctions = 626,
        CommandReloadAutobroadcast = 627,
        CommandReloadCommand = 628,
        CommandReloadConditions = 629,
        CommandReloadConfig = 630,
        CommandReloadBattlegroundTemplate = 631,
        CommandMutehistory = 632,
        CommandReloadCreatureLinkedRespawn = 633,
        CommandReloadCreatureLootTemplate = 634,
        CommandReloadCreatureOnkillReputation = 635,
        CommandReloadCreatureQuestender = 636,
        CommandReloadCreatureQueststarter = 637,
        CommandReloadCreatureSummonGroups = 638,
        CommandReloadCreatureTemplate = 639,
        CommandReloadCreatureText = 640,
        CommandReloadDisables = 641,
        CommandReloadDisenchantLootTemplate = 642,
        CommandReloadEventScripts = 643,
        CommandReloadFishingLootTemplate = 644,
        CommandReloadGraveyardZone = 645,
        CommandReloadGameTele = 646,
        CommandReloadGameobjectQuestender = 647,
        CommandReloadGameobjectQuestLootTemplate = 648,
        CommandReloadGameobjectQueststarter = 649,
        CommandReloadSupportSystem = 650,
        CommandReloadGossipMenu = 651,
        CommandReloadGossipMenuOption = 652,
        CommandReloadItemEnchantmentTemplate = 653,
        CommandReloadItemLootTemplate = 654,
        CommandReloadItemSetNames = 655,
        CommandReloadLfgDungeonRewards = 656,
        CommandReloadLocalesAchievementReward = 657,
        CommandReloadLocalesCreature = 658,
        CommandReloadLocalesCreatureText = 659,
        CommandReloadLocalesGameobject = 660,
        CommandReloadLocalesGossipMenuOption = 661,
        // 662 Unused
        CommandReloadLocalesItemSetName = 663,
        // 664 Unused
        CommandReloadLocalesPageText = 665,
        CommandReloadLocalesPointsOfInterest = 666,
        CommandReloadQuestLocale = 667,
        CommandReloadMailLevelReward = 668,
        CommandReloadMailLootTemplate = 669,
        CommandReloadMillingLootTemplate = 670,
        CommandReloadNpcSpellclickSpells = 671,
        CommandReloadTrainer = 672,
        CommandReloadNpcVendor = 673,
        CommandReloadPageText = 674,
        CommandReloadPickpocketingLootTemplate = 675,
        CommandReloadPointsOfInterest = 676,
        CommandReloadProspectingLootTemplate = 677,
        CommandReloadQuestPoi = 678,
        CommandReloadQuestTemplate = 679,
        CommandReloadRbac = 680,
        CommandReloadReferenceLootTemplate = 681,
        CommandReloadReservedName = 682,
        CommandReloadReputationRewardRate = 683,
        CommandReloadSpilloverTemplate = 684,
        CommandReloadSkillDiscoveryTemplate = 685,
        CommandReloadSkillExtraItemTemplate = 686,
        CommandReloadSkillFishingBaseLevel = 687,
        CommandReloadSkinningLootTemplate = 688,
        CommandReloadSmartScripts = 689,
        CommandReloadSpellRequired = 690,
        CommandReloadSpellArea = 691,
        // 692 Unused
        CommandReloadSpellGroup = 693,
        CommandReloadSpellLearnSpell = 694,
        CommandReloadSpellLootTemplate = 695,
        CommandReloadSpellLinkedSpell = 696,
        CommandReloadSpellPetAuras = 697,
        // 698 - reuse
        CommandReloadSpellProc = 699,
        CommandReloadSpellScripts = 700,
        CommandReloadSpellTargetPosition = 701,
        CommandReloadSpellThreats = 702,
        CommandReloadSpellGroupStackRules = 703,
        CommandReloadCypherString = 704,
        CommandReloadWardenAction = 705,
        CommandReloadWaypointScripts = 706,
        CommandReloadWaypointData = 707,
        CommandReloadVehicleAccesory = 708,
        CommandReloadVehicleTemplateAccessory = 709,
        CommandReset = 710,
        CommandResetAchievements = 711,
        CommandResetHonor = 712,
        CommandResetLevel = 713,
        CommandResetSpells = 714,
        CommandResetStats = 715,
        CommandResetTalents = 716,
        CommandResetAll = 717,
        CommandServer = 718,
        CommandServerCorpses = 719,
        CommandServerExit = 720,
        CommandServerIdlerestart = 721,
        CommandServerIdlerestartCancel = 722,
        CommandServerIdleshutdown = 723,
        CommandServerIdleshutdownCancel = 724,
        CommandServerInfo = 725,
        CommandServerPlimit = 726,
        CommandServerRestart = 727,
        CommandServerRestartCancel = 728,
        CommandServerSet = 729,
        CommandServerSetClosed = 730,
        CommandServerSetDifftime = 731,
        CommandServerSetLoglevel = 732,
        CommandServerSetMotd = 733,
        CommandServerShutdown = 734,
        CommandServerShutdownCancel = 735,
        CommandServerMotd = 736,
        CommandTele = 737,
        CommandTeleAdd = 738,
        CommandTeleDel = 739,
        CommandTeleName = 740,
        CommandTeleGroup = 741,
        CommandTicket = 742,
        // 743 - 752 reuse
        CommandTicketReset = 753,
        // 754 - 756 reuse
        CommandTicketTogglesystem = 757,
        // 758 - 760 reuse
        CommandTitles = 761,
        CommandTitlesAdd = 762,
        CommandTitlesCurrent = 763,
        CommandTitlesRemove = 764,
        CommandTitlesSet = 765,
        CommandTitlesSetMask = 766,
        CommandWp = 767,
        CommandWpAdd = 768,
        CommandWpEvent = 769,
        CommandWpLoad = 770,
        CommandWpModify = 771,
        CommandWpUnload = 772,
        CommandWpReload = 773,
        CommandWpShow = 774,
        CommandModifyCurrency = 775, // Only 4.3.4
        CommandDebugPhase = 776, // Only 4.3.4
        CommandMailbox = 777,
        CommandAhbot = 778,
        CommandAhbotItems = 779,
        CommandAhbotItemsGray = 780,
        CommandAhbotItemsWhite = 781,
        CommandAhbotItemsGreen = 782,
        CommandAhbotItemsBlue = 783,
        CommandAhbotItemsPurple = 784,
        CommandAhbotItemsOrange = 785,
        CommandAhbotItemsYellow = 786,
        CommandAhbotRatio = 787,
        CommandAhbotRatioAlliance = 788,
        CommandAhbotRatioHorde = 789,
        CommandAhbotRatioNeutral = 790,
        CommandAhbotRebuild = 791,
        CommandAhbotReload = 792,
        CommandAhbotStatus = 793,
        CommandGuildInfo = 794,
        CommandInstanceSetBossState = 795,
        CommandInstanceGetBossState = 796,
        CommandPvpstats = 797,
        CommandModifyXp = 798,
        CommandGoBugTicket = 799,
        CommandGoComplaintTicket = 800,
        CommandGoSuggestionTicket = 801,
        CommandTicketBug = 802,
        CommandTicketComplaint = 803,
        CommandTicketSuggestion = 804,
        CommandTicketBugAssign = 805,
        CommandTicketBugClose = 806,
        CommandTicketBugClosedlist = 807,
        CommandTicketBugComment = 808,
        CommandTicketBugDelete = 809,
        CommandTicketBugList = 810,
        CommandTicketBugUnassign = 811,
        CommandTicketBugView = 812,
        CommandTicketComplaintAssign = 813,
        CommandTicketComplaintClose = 814,
        CommandTicketComplaintClosedlist = 815,
        CommandTicketComplaintComment = 816,
        CommandTicketComplaintDelete = 817,
        CommandTicketComplaintList = 818,
        CommandTicketComplaintUnassign = 819,
        CommandTicketComplaintView = 820,
        CommandTicketSuggestionAssign = 821,
        CommandTicketSuggestionClose = 822,
        CommandTicketSuggestionClosedlist = 823,
        CommandTicketSuggestionComment = 824,
        CommandTicketSuggestionDelete = 825,
        CommandTicketSuggestionList = 826,
        CommandTicketSuggestionUnassign = 827,
        CommandTicketSuggestionView = 828,
        CommandTicketResetAll = 829,
        CommandBnetAccountListGameAccounts = 830,
        CommandTicketResetBug = 831,
        CommandTicketResetComplaint = 832,
        CommandTicketResetSuggestion = 833,
        CommandGoQuest = 834,
        CommandDebugLoadcells = 835,
        CommandDebugBoundary = 836,
        CommandNpcEvade = 837,
        CommandPetLevel = 838,
        CommandServerShutdownForce = 839,
        CommandServerRestartForce = 840,
        CommandNearGraveyard = 841,
        CommandReloadCharacterTemplate = 842,
        CommandReloadQuestGreeting = 843,
        CommandScene = 844,
        CommandSceneDedug = 845,
        CommandScenePlay = 846,
        CommandScenePlayPackage = 847,
        CommandSceneCancel = 848,
        CommandListScenes = 849,
        CommandReloacSceneTemplate = 850,
        CommandReloadAreatriggerTemplate = 851,
        CommandGoOffset = 852,
        CommandReloadConversationTemplate = 853,
        CommandDebugConversation = 854,

        // Custom Permissions 1000+
        Max
    }

    public enum MountStatusFlags
    {
        None = 0x00,
        NeedsFanfare = 0x01,
        IsFavorite = 0x02
    }
}
