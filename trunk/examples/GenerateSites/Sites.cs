using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stacky
{
    public static class Sites
    {
		public static Site StackOverflow
        {
            get
            {
                return new Site
                {
                    Name = "Stack Overflow",
                    LogoUrl = "http://sstatic.net/stackoverflow/img/logo.png",
                    ApiEndpoint = "http://api.stackoverflow.com",
                    SiteUrl = "http://stackoverflow.com",
                    Description = "Q&A for professional and enthusiast programmers",
                    IconUrl = "http://sstatic.net/stackoverflow/img/apple-touch-icon.png",
					State = SiteState.Normal
                };
            }
        }

		public static Site ServerFault
        {
            get
            {
                return new Site
                {
                    Name = "Server Fault",
                    LogoUrl = "http://sstatic.net/serverfault/img/logo.png",
                    ApiEndpoint = "http://api.serverfault.com",
                    SiteUrl = "http://serverfault.com",
                    Description = "Q&A for system administrators and desktop support professionals",
                    IconUrl = "http://sstatic.net/serverfault/img/apple-touch-icon.png",
					State = SiteState.Normal
                };
            }
        }

		public static Site SuperUser
        {
            get
            {
                return new Site
                {
                    Name = "Super User",
                    LogoUrl = "http://sstatic.net/superuser/img/logo.png",
                    ApiEndpoint = "http://api.superuser.com",
                    SiteUrl = "http://superuser.com",
                    Description = "Q&A for computer enthusiasts and power users",
                    IconUrl = "http://sstatic.net/superuser/img/apple-touch-icon.png",
					State = SiteState.Normal
                };
            }
        }

		public static Site MetaStackOverflow
        {
            get
            {
                return new Site
                {
                    Name = "Meta Stack Overflow",
                    LogoUrl = "http://sstatic.net/stackoverflowmeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.stackoverflow.com",
                    SiteUrl = "http://meta.stackoverflow.com",
                    Description = "Q&A for the Stack Exchange engine powering these sites",
                    IconUrl = "http://sstatic.net/stackoverflowmeta/img/apple-touch-icon.png",
					State = SiteState.Normal
                };
            }
        }

		public static Site WebApplications
        {
            get
            {
                return new Site
                {
                    Name = "Web Applications",
                    LogoUrl = "http://sstatic.net/webapps/img/logo.png",
                    ApiEndpoint = "http://api.webapps.stackexchange.com",
                    SiteUrl = "http://webapps.stackexchange.com",
                    Description = "Q&A for power users of web applications",
                    IconUrl = "http://sstatic.net/webapps/img/apple-touch-icon.png",
					State = SiteState.Normal
                };
            }
        }

		public static Site WebApplicationsMeta
        {
            get
            {
                return new Site
                {
                    Name = "Web Applications Meta",
                    LogoUrl = "http://sstatic.net/webappsmeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.webapps.stackexchange.com",
                    SiteUrl = "http://meta.webapps.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for power users of web applications",
                    IconUrl = "http://sstatic.net/webappsmeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site Gaming
        {
            get
            {
                return new Site
                {
                    Name = "Gaming",
                    LogoUrl = "http://sstatic.net/gaming/img/logo.png",
                    ApiEndpoint = "http://api.gaming.stackexchange.com",
                    SiteUrl = "http://gaming.stackexchange.com",
                    Description = "Q&A for passionate videogamers on all platforms",
                    IconUrl = "http://sstatic.net/gaming/img/apple-touch-icon.png",
					State = SiteState.Normal
                };
            }
        }

		public static Site GamingMeta
        {
            get
            {
                return new Site
                {
                    Name = "Gaming Meta",
                    LogoUrl = "http://sstatic.net/gamingmeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.gaming.stackexchange.com",
                    SiteUrl = "http://meta.gaming.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for passionate videogamers on all platforms",
                    IconUrl = "http://sstatic.net/gamingmeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site Webmasters
        {
            get
            {
                return new Site
                {
                    Name = "Webmasters",
                    LogoUrl = "http://sstatic.net/webmasters/img/logo.png",
                    ApiEndpoint = "http://api.webmasters.stackexchange.com",
                    SiteUrl = "http://webmasters.stackexchange.com",
                    Description = "Q&A for pro webmasters",
                    IconUrl = "http://sstatic.net/webmasters/img/apple-touch-icon.png",
					State = SiteState.Normal
                };
            }
        }

		public static Site WebmastersMeta
        {
            get
            {
                return new Site
                {
                    Name = "Webmasters Meta",
                    LogoUrl = "http://sstatic.net/webmastersmeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.webmasters.stackexchange.com",
                    SiteUrl = "http://meta.webmasters.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for pro webmasters",
                    IconUrl = "http://sstatic.net/webmastersmeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site Cooking
        {
            get
            {
                return new Site
                {
                    Name = "Cooking",
                    LogoUrl = "http://sstatic.net/cooking/img/logo.png",
                    ApiEndpoint = "http://api.cooking.stackexchange.com",
                    SiteUrl = "http://cooking.stackexchange.com",
                    Description = "Q&A for professional and amateur chefs",
                    IconUrl = "http://sstatic.net/cooking/img/apple-touch-icon.png",
					State = SiteState.Normal
                };
            }
        }

		public static Site CookingMeta
        {
            get
            {
                return new Site
                {
                    Name = "Cooking Meta",
                    LogoUrl = "http://sstatic.net/cookingmeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.cooking.stackexchange.com",
                    SiteUrl = "http://meta.cooking.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for professional and amateur chefs",
                    IconUrl = "http://sstatic.net/cookingmeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site GameDevelopment
        {
            get
            {
                return new Site
                {
                    Name = "Game Development",
                    LogoUrl = "http://sstatic.net/gamedev/img/logo.png",
                    ApiEndpoint = "http://api.gamedev.stackexchange.com",
                    SiteUrl = "http://gamedev.stackexchange.com",
                    Description = "Q&A for professional and independent game developers",
                    IconUrl = "http://sstatic.net/gamedev/img/apple-touch-icon.png",
					State = SiteState.Normal
                };
            }
        }

		public static Site GameDevelopmentMeta
        {
            get
            {
                return new Site
                {
                    Name = "Game Development Meta",
                    LogoUrl = "http://sstatic.net/gamedevmeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.gamedev.stackexchange.com",
                    SiteUrl = "http://meta.gamedev.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for professional and independent game developers",
                    IconUrl = "http://sstatic.net/gamedevmeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site Photography
        {
            get
            {
                return new Site
                {
                    Name = "Photography",
                    LogoUrl = "http://sstatic.net/photo/img/logo.png",
                    ApiEndpoint = "http://api.photo.stackexchange.com",
                    SiteUrl = "http://photo.stackexchange.com",
                    Description = "Q&A for professional photographers, photo editors, and serious enthusiasts",
                    IconUrl = "http://sstatic.net/photo/img/apple-touch-icon.png",
					State = SiteState.Normal
                };
            }
        }

		public static Site PhotographyMeta
        {
            get
            {
                return new Site
                {
                    Name = "Photography Meta",
                    LogoUrl = "http://sstatic.net/photometa/img/logo.png",
                    ApiEndpoint = "http://api.meta.photo.stackexchange.com",
                    SiteUrl = "http://meta.photo.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for professional photographers, photo editors, and serious enthusiasts",
                    IconUrl = "http://sstatic.net/photometa/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site StatisticalAnalysis
        {
            get
            {
                return new Site
                {
                    Name = "Statistical Analysis",
                    LogoUrl = "http://sstatic.net/stats/img/logo.png",
                    ApiEndpoint = "http://api.stats.stackexchange.com",
                    SiteUrl = "http://stats.stackexchange.com",
                    Description = "Q&A for statisticians, data analysts, data miners and data visualization experts",
                    IconUrl = "http://sstatic.net/stats/img/apple-touch-icon.png",
					State = SiteState.Normal
                };
            }
        }

		public static Site StatisticalAnalysisMeta
        {
            get
            {
                return new Site
                {
                    Name = "Statistical Analysis Meta",
                    LogoUrl = "http://sstatic.net/statsmeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.stats.stackexchange.com",
                    SiteUrl = "http://meta.stats.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for statisticians, data analysts, data miners and data visualization experts",
                    IconUrl = "http://sstatic.net/statsmeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site Mathematics
        {
            get
            {
                return new Site
                {
                    Name = "Mathematics",
                    LogoUrl = "http://sstatic.net/math/img/logo.png",
                    ApiEndpoint = "http://api.math.stackexchange.com",
                    SiteUrl = "http://math.stackexchange.com",
                    Description = "Q&A for people studying math at any level and professionals in related fields",
                    IconUrl = "http://sstatic.net/math/img/apple-touch-icon.png",
					State = SiteState.Normal
                };
            }
        }

		public static Site MathematicsMeta
        {
            get
            {
                return new Site
                {
                    Name = "Mathematics Meta",
                    LogoUrl = "http://sstatic.net/mathmeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.math.stackexchange.com",
                    SiteUrl = "http://meta.math.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for people studying math at any level and professionals in related fields",
                    IconUrl = "http://sstatic.net/mathmeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site HomeImprovement
        {
            get
            {
                return new Site
                {
                    Name = "Home Improvement",
                    LogoUrl = "http://sstatic.net/diy/img/logo.png",
                    ApiEndpoint = "http://api.diy.stackexchange.com",
                    SiteUrl = "http://diy.stackexchange.com",
                    Description = "Q&A for contractors and serious DIYers",
                    IconUrl = "http://sstatic.net/diy/img/apple-touch-icon.png",
					State = SiteState.Open_Beta
                };
            }
        }

		public static Site HomeImprovementMeta
        {
            get
            {
                return new Site
                {
                    Name = "Home Improvement Meta",
                    LogoUrl = "http://sstatic.net/diymeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.diy.stackexchange.com",
                    SiteUrl = "http://meta.diy.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for contractors and serious DIYers",
                    IconUrl = "http://sstatic.net/diymeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site MetaSuperUser
        {
            get
            {
                return new Site
                {
                    Name = "Meta Super User",
                    LogoUrl = "http://sstatic.net/superusermeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.superuser.com",
                    SiteUrl = "http://meta.superuser.com",
                    Description = "Q&A about the Stack Exchange site for computer enthusiasts and power users",
                    IconUrl = "http://sstatic.net/superusermeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site MetaServerFault
        {
            get
            {
                return new Site
                {
                    Name = "Meta Server Fault",
                    LogoUrl = "http://sstatic.net/serverfaultmeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.serverfault.com",
                    SiteUrl = "http://meta.serverfault.com",
                    Description = "Q&A about the Stack Exchange site for system administrators and IT professionals",
                    IconUrl = "http://sstatic.net/serverfaultmeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site GIS
        {
            get
            {
                return new Site
                {
                    Name = "GIS",
                    LogoUrl = "http://sstatic.net/gis/img/logo.png",
                    ApiEndpoint = "http://api.gis.stackexchange.com",
                    SiteUrl = "http://gis.stackexchange.com",
                    Description = "Q&A for cartographers, geographers and GIS professionals",
                    IconUrl = "http://sstatic.net/gis/img/apple-touch-icon.png",
					State = SiteState.Open_Beta
                };
            }
        }

		public static Site GISMeta
        {
            get
            {
                return new Site
                {
                    Name = "GIS Meta",
                    LogoUrl = "http://sstatic.net/gismeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.gis.stackexchange.com",
                    SiteUrl = "http://meta.gis.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for cartographers, geographers and GIS professionals",
                    IconUrl = "http://sstatic.net/gismeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site TeXLaTeX
        {
            get
            {
                return new Site
                {
                    Name = "TeX - LaTeX",
                    LogoUrl = "http://sstatic.net/tex/img/logo.png",
                    ApiEndpoint = "http://api.tex.stackexchange.com",
                    SiteUrl = "http://tex.stackexchange.com",
                    Description = "Q&A for users of TeX, LaTeX, ConTeXt, and related typesetting systems",
                    IconUrl = "http://sstatic.net/tex/img/apple-touch-icon.png",
					State = SiteState.Normal
                };
            }
        }

		public static Site TeXLaTeXMeta
        {
            get
            {
                return new Site
                {
                    Name = "TeX - LaTeX Meta",
                    LogoUrl = "http://sstatic.net/texmeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.tex.stackexchange.com",
                    SiteUrl = "http://meta.tex.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for users of TeX, LaTeX, ConTeXt, and related typesetting systems",
                    IconUrl = "http://sstatic.net/texmeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site AskUbuntu
        {
            get
            {
                return new Site
                {
                    Name = "Ask Ubuntu",
                    LogoUrl = "http://sstatic.net/askubuntu/img/logo.png",
                    ApiEndpoint = "http://api.askubuntu.com",
                    SiteUrl = "http://askubuntu.com",
                    Description = "Q&A for Ubuntu users and developers",
                    IconUrl = "http://sstatic.net/askubuntu/img/apple-touch-icon.png",
					State = SiteState.Normal
                };
            }
        }

		public static Site AskUbuntuMeta
        {
            get
            {
                return new Site
                {
                    Name = "Ask Ubuntu Meta",
                    LogoUrl = "http://sstatic.net/askubuntumeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.askubuntu.com",
                    SiteUrl = "http://meta.askubuntu.com",
                    Description = "Q&A about the Stack Exchange site for Ubuntu users and developers",
                    IconUrl = "http://sstatic.net/askubuntumeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site PersonalFinanceandMoney
        {
            get
            {
                return new Site
                {
                    Name = "Personal Finance and Money",
                    LogoUrl = "http://sstatic.net/money/img/logo.png",
                    ApiEndpoint = "http://api.money.stackexchange.com",
                    SiteUrl = "http://money.stackexchange.com",
                    Description = "Q&A for people who want to be financially literate",
                    IconUrl = "http://sstatic.net/money/img/apple-touch-icon.png",
					State = SiteState.Open_Beta
                };
            }
        }

		public static Site PersonalFinanceandMoneyMeta
        {
            get
            {
                return new Site
                {
                    Name = "Personal Finance and Money Meta",
                    LogoUrl = "http://sstatic.net/moneymeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.money.stackexchange.com",
                    SiteUrl = "http://meta.money.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for people who want to be financially literate",
                    IconUrl = "http://sstatic.net/moneymeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site EnglishLanguageandUsage
        {
            get
            {
                return new Site
                {
                    Name = "English Language and Usage",
                    LogoUrl = "http://sstatic.net/english/img/logo.png",
                    ApiEndpoint = "http://api.english.stackexchange.com",
                    SiteUrl = "http://english.stackexchange.com",
                    Description = "Q&A for linguists, etymologists, and serious English language enthusiasts",
                    IconUrl = "http://sstatic.net/english/img/apple-touch-icon.png",
					State = SiteState.Normal
                };
            }
        }

		public static Site EnglishLanguageandUsageMeta
        {
            get
            {
                return new Site
                {
                    Name = "English Language and Usage Meta",
                    LogoUrl = "http://sstatic.net/englishmeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.english.stackexchange.com",
                    SiteUrl = "http://meta.english.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for linguists, etymologists, and serious English language enthusiasts",
                    IconUrl = "http://sstatic.net/englishmeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site StackApps
        {
            get
            {
                return new Site
                {
                    Name = "Stack Apps",
                    LogoUrl = "http://sstatic.net/stackapps/img/logo.png",
                    ApiEndpoint = "http://api.stackapps.com",
                    SiteUrl = "http://stackapps.com",
                    Description = "Q&A for apps, scripts, and development with the Stack Exchange API",
                    IconUrl = "http://sstatic.net/stackapps/img/apple-touch-icon.png",
					State = SiteState.Normal
                };
            }
        }

		public static Site UserInterface
        {
            get
            {
                return new Site
                {
                    Name = "User Interface",
                    LogoUrl = "http://sstatic.net/ui/img/logo.png",
                    ApiEndpoint = "http://api.ui.stackexchange.com",
                    SiteUrl = "http://ui.stackexchange.com",
                    Description = "Q&A for user interface researchers and experts",
                    IconUrl = "http://sstatic.net/ui/img/apple-touch-icon.png",
					State = SiteState.Open_Beta
                };
            }
        }

		public static Site UserInterfaceMeta
        {
            get
            {
                return new Site
                {
                    Name = "User Interface Meta",
                    LogoUrl = "http://sstatic.net/uimeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.ui.stackexchange.com",
                    SiteUrl = "http://meta.ui.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for user interface researchers and experts",
                    IconUrl = "http://sstatic.net/uimeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site UnixandLinux
        {
            get
            {
                return new Site
                {
                    Name = "Unix and Linux",
                    LogoUrl = "http://sstatic.net/unix/img/logo.png",
                    ApiEndpoint = "http://api.unix.stackexchange.com",
                    SiteUrl = "http://unix.stackexchange.com",
                    Description = "Q&A for users of Linux, FreeBSD and other Un*x-like operating systems.",
                    IconUrl = "http://sstatic.net/unix/img/apple-touch-icon.png",
					State = SiteState.Normal
                };
            }
        }

		public static Site UnixandLinuxMeta
        {
            get
            {
                return new Site
                {
                    Name = "Unix and Linux Meta",
                    LogoUrl = "http://sstatic.net/unixmeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.unix.stackexchange.com",
                    SiteUrl = "http://meta.unix.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for users of Linux, FreeBSD and other Un*x-like operating systems.",
                    IconUrl = "http://sstatic.net/unixmeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site WordPress
        {
            get
            {
                return new Site
                {
                    Name = "WordPress",
                    LogoUrl = "http://sstatic.net/wordpress/img/logo.png",
                    ApiEndpoint = "http://api.wordpress.stackexchange.com",
                    SiteUrl = "http://wordpress.stackexchange.com",
                    Description = "Q&A for WordPress developers and administrators",
                    IconUrl = "http://sstatic.net/wordpress/img/apple-touch-icon.png",
					State = SiteState.Normal
                };
            }
        }

		public static Site WordPressMeta
        {
            get
            {
                return new Site
                {
                    Name = "WordPress Meta",
                    LogoUrl = "http://sstatic.net/wordpressmeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.wordpress.stackexchange.com",
                    SiteUrl = "http://meta.wordpress.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for WordPress developers and administrators",
                    IconUrl = "http://sstatic.net/wordpressmeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site TheoreticalComputerScience
        {
            get
            {
                return new Site
                {
                    Name = "Theoretical Computer Science",
                    LogoUrl = "http://sstatic.net/cstheory/img/logo.png",
                    ApiEndpoint = "http://api.cstheory.stackexchange.com",
                    SiteUrl = "http://cstheory.stackexchange.com",
                    Description = "Q&A for theoretical computer scientists and researchers in related fields",
                    IconUrl = "http://sstatic.net/cstheory/img/apple-touch-icon.png",
					State = SiteState.Normal
                };
            }
        }

		public static Site TheoreticalComputerScienceMeta
        {
            get
            {
                return new Site
                {
                    Name = "Theoretical Computer Science Meta",
                    LogoUrl = "http://sstatic.net/cstheorymeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.cstheory.stackexchange.com",
                    SiteUrl = "http://meta.cstheory.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for theoretical computer scientists and researchers in related fields",
                    IconUrl = "http://sstatic.net/cstheorymeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site Apple
        {
            get
            {
                return new Site
                {
                    Name = "Apple",
                    LogoUrl = "http://sstatic.net/apple/img/logo.png",
                    ApiEndpoint = "http://api.apple.stackexchange.com",
                    SiteUrl = "http://apple.stackexchange.com",
                    Description = "Q&A for power users of Apple hardware and software",
                    IconUrl = "http://sstatic.net/apple/img/apple-touch-icon.png",
					State = SiteState.Normal
                };
            }
        }

		public static Site AppleMeta
        {
            get
            {
                return new Site
                {
                    Name = "Apple Meta",
                    LogoUrl = "http://sstatic.net/applemeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.apple.stackexchange.com",
                    SiteUrl = "http://meta.apple.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for power users of Apple hardware and software",
                    IconUrl = "http://sstatic.net/applemeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site RoleplayingGames
        {
            get
            {
                return new Site
                {
                    Name = "Role-playing Games",
                    LogoUrl = "http://sstatic.net/rpg/img/logo.png",
                    ApiEndpoint = "http://api.rpg.stackexchange.com",
                    SiteUrl = "http://rpg.stackexchange.com",
                    Description = "Q&A for gamemasters and players of tabletop, paper-and-pencil role-playing games",
                    IconUrl = "http://sstatic.net/rpg/img/apple-touch-icon.png",
					State = SiteState.Open_Beta
                };
            }
        }

		public static Site RoleplayingGamesMeta
        {
            get
            {
                return new Site
                {
                    Name = "Role-playing Games Meta",
                    LogoUrl = "http://sstatic.net/rpgmeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.rpg.stackexchange.com",
                    SiteUrl = "http://meta.rpg.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for gamemasters and players of tabletop, paper-and-pencil role-playing games",
                    IconUrl = "http://sstatic.net/rpgmeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site Bicycles
        {
            get
            {
                return new Site
                {
                    Name = "Bicycles",
                    LogoUrl = "http://sstatic.net/bicycles/img/logo.png",
                    ApiEndpoint = "http://api.bicycles.stackexchange.com",
                    SiteUrl = "http://bicycles.stackexchange.com",
                    Description = "Q&A for people who build and repair bicycles, people who train cycling, or commute on bicycles",
                    IconUrl = "http://sstatic.net/bicycles/img/apple-touch-icon.png",
					State = SiteState.Open_Beta
                };
            }
        }

		public static Site BicyclesMeta
        {
            get
            {
                return new Site
                {
                    Name = "Bicycles Meta",
                    LogoUrl = "http://sstatic.net/bicyclesmeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.bicycles.stackexchange.com",
                    SiteUrl = "http://meta.bicycles.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for people who build and repair bicycles, people who train cycling, or commute on bicycles",
                    IconUrl = "http://sstatic.net/bicyclesmeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site Programmers
        {
            get
            {
                return new Site
                {
                    Name = "Programmers",
                    LogoUrl = "http://sstatic.net/programmers/img/logo.png",
                    ApiEndpoint = "http://api.programmers.stackexchange.com",
                    SiteUrl = "http://programmers.stackexchange.com",
                    Description = "Q&A for expert programmers interested in professional discussions on software development",
                    IconUrl = "http://sstatic.net/programmers/img/apple-touch-icon.png",
					State = SiteState.Normal
                };
            }
        }

		public static Site ProgrammersMeta
        {
            get
            {
                return new Site
                {
                    Name = "Programmers Meta",
                    LogoUrl = "http://sstatic.net/programmersmeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.programmers.stackexchange.com",
                    SiteUrl = "http://meta.programmers.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for expert programmers interested in professional discussions on software development",
                    IconUrl = "http://sstatic.net/programmersmeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site ElectronicsandRobotics
        {
            get
            {
                return new Site
                {
                    Name = "Electronics and Robotics",
                    LogoUrl = "http://sstatic.net/electronics/img/logo.png",
                    ApiEndpoint = "http://api.electronics.stackexchange.com",
                    SiteUrl = "http://electronics.stackexchange.com",
                    Description = "Q&A for electronics and robotics hardware hacking enthusiasts.",
                    IconUrl = "http://sstatic.net/electronics/img/apple-touch-icon.png",
					State = SiteState.Open_Beta
                };
            }
        }

		public static Site ElectronicsandRoboticsMeta
        {
            get
            {
                return new Site
                {
                    Name = "Electronics and Robotics Meta",
                    LogoUrl = "http://sstatic.net/electronicsmeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.electronics.stackexchange.com",
                    SiteUrl = "http://meta.electronics.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for electronics and robotics hardware hacking enthusiasts.",
                    IconUrl = "http://sstatic.net/electronicsmeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site AndroidEnthusiasts
        {
            get
            {
                return new Site
                {
                    Name = "Android Enthusiasts",
                    LogoUrl = "http://sstatic.net/android/img/logo.png",
                    ApiEndpoint = "http://api.android.stackexchange.com",
                    SiteUrl = "http://android.stackexchange.com",
                    Description = "Q&A for enthusiasts and power users of the Android operating system",
                    IconUrl = "http://sstatic.net/android/img/apple-touch-icon.png",
					State = SiteState.Open_Beta
                };
            }
        }

		public static Site AndroidEnthusiastsMeta
        {
            get
            {
                return new Site
                {
                    Name = "Android Enthusiasts Meta",
                    LogoUrl = "http://sstatic.net/androidmeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.android.stackexchange.com",
                    SiteUrl = "http://meta.android.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for enthusiasts and power users of the Android operating system",
                    IconUrl = "http://sstatic.net/androidmeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site OnStartups
        {
            get
            {
                return new Site
                {
                    Name = "OnStartups",
                    LogoUrl = "http://sstatic.net/onstartups/img/logo.png",
                    ApiEndpoint = "http://api.onstartups.stackexchange.com",
                    SiteUrl = "http://answers.onstartups.com",
                    Description = "Q&A for entrepreneurs looking to start or run a new business",
                    IconUrl = "http://sstatic.net/onstartups/img/apple-touch-icon.png",
					State = SiteState.Open_Beta
                };
            }
        }

		public static Site OnStartupsMeta
        {
            get
            {
                return new Site
                {
                    Name = "OnStartups Meta",
                    LogoUrl = "http://sstatic.net/onstartupsmeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.onstartups.stackexchange.com",
                    SiteUrl = "http://meta.answers.onstartups.com",
                    Description = "Q&A about the Stack Exchange site for entrepreneurs looking to start or run a new business",
                    IconUrl = "http://sstatic.net/onstartupsmeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site BoardandCardGames
        {
            get
            {
                return new Site
                {
                    Name = "Board and Card Games",
                    LogoUrl = "http://sstatic.net/boardgames/img/logo.png",
                    ApiEndpoint = "http://api.boardgames.stackexchange.com",
                    SiteUrl = "http://boardgames.stackexchange.com",
                    Description = "Q&A for people who like playing board games, designing board games or modifying the rules of existing board games",
                    IconUrl = "http://sstatic.net/boardgames/img/apple-touch-icon.png",
					State = SiteState.Open_Beta
                };
            }
        }

		public static Site BoardandCardGamesMeta
        {
            get
            {
                return new Site
                {
                    Name = "Board and Card Games Meta",
                    LogoUrl = "http://sstatic.net/boardgamesmeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.boardgames.stackexchange.com",
                    SiteUrl = "http://meta.boardgames.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for people who like playing board games, designing board games or modifying the rules of existing board games",
                    IconUrl = "http://sstatic.net/boardgamesmeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site Physics
        {
            get
            {
                return new Site
                {
                    Name = "Physics",
                    LogoUrl = "http://sstatic.net/physics/img/logo.png",
                    ApiEndpoint = "http://api.physics.stackexchange.com",
                    SiteUrl = "http://physics.stackexchange.com",
                    Description = "Q&A for active researchers, academics and students of physics",
                    IconUrl = "http://sstatic.net/physics/img/apple-touch-icon.png",
					State = SiteState.Normal
                };
            }
        }

		public static Site PhysicsMeta
        {
            get
            {
                return new Site
                {
                    Name = "Physics Meta",
                    LogoUrl = "http://sstatic.net/physicsmeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.physics.stackexchange.com",
                    SiteUrl = "http://meta.physics.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for active researchers, academics and students of physics",
                    IconUrl = "http://sstatic.net/physicsmeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site Homebrew
        {
            get
            {
                return new Site
                {
                    Name = "Homebrew",
                    LogoUrl = "http://sstatic.net/homebrew/img/logo.png",
                    ApiEndpoint = "http://api.homebrew.stackexchange.com",
                    SiteUrl = "http://homebrew.stackexchange.com",
                    Description = "Q&A for dedicated home brewers and serious enthusiasts",
                    IconUrl = "http://sstatic.net/homebrew/img/apple-touch-icon.png",
					State = SiteState.Open_Beta
                };
            }
        }

		public static Site HomebrewMeta
        {
            get
            {
                return new Site
                {
                    Name = "Homebrew Meta",
                    LogoUrl = "http://sstatic.net/homebrewmeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.homebrew.stackexchange.com",
                    SiteUrl = "http://meta.homebrew.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for dedicated home brewers and serious enthusiasts",
                    IconUrl = "http://sstatic.net/homebrewmeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site ITSecurity
        {
            get
            {
                return new Site
                {
                    Name = "IT Security",
                    LogoUrl = "http://sstatic.net/security/img/logo.png",
                    ApiEndpoint = "http://api.security.stackexchange.com",
                    SiteUrl = "http://security.stackexchange.com",
                    Description = "Q&A for IT security professionals",
                    IconUrl = "http://sstatic.net/security/img/apple-touch-icon.png",
					State = SiteState.Open_Beta
                };
            }
        }

		public static Site ITSecurityMeta
        {
            get
            {
                return new Site
                {
                    Name = "IT Security Meta",
                    LogoUrl = "http://sstatic.net/securitymeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.security.stackexchange.com",
                    SiteUrl = "http://meta.security.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for IT security professionals",
                    IconUrl = "http://sstatic.net/securitymeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site Writers
        {
            get
            {
                return new Site
                {
                    Name = "Writers",
                    LogoUrl = "http://sstatic.net/writers/img/logo.png",
                    ApiEndpoint = "http://api.writers.stackexchange.com",
                    SiteUrl = "http://writers.stackexchange.com",
                    Description = "Q&A for authors, editors, reviewers, professional writers, and aspiring writers",
                    IconUrl = "http://sstatic.net/writers/img/apple-touch-icon.png",
					State = SiteState.Open_Beta
                };
            }
        }

		public static Site WritersMeta
        {
            get
            {
                return new Site
                {
                    Name = "Writers Meta",
                    LogoUrl = "http://sstatic.net/writersmeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.writers.stackexchange.com",
                    SiteUrl = "http://meta.writers.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for authors, editors, reviewers, professional writers, and aspiring writers",
                    IconUrl = "http://sstatic.net/writersmeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site AudioRecordingandProduction
        {
            get
            {
                return new Site
                {
                    Name = "Audio Recording and Production",
                    LogoUrl = "http://sstatic.net/audio/img/logo.png",
                    ApiEndpoint = "http://api.audio.stackexchange.com",
                    SiteUrl = "http://audio.stackexchange.com",
                    Description = "Q&A for recording enthusiasts and professionals, audio engineers, producers, music composers and arrangers",
                    IconUrl = "http://sstatic.net/audio/img/apple-touch-icon.png",
					State = SiteState.Open_Beta
                };
            }
        }

		public static Site AudioRecordingandProductionMeta
        {
            get
            {
                return new Site
                {
                    Name = "Audio Recording and Production Meta",
                    LogoUrl = "http://sstatic.net/audiometa/img/logo.png",
                    ApiEndpoint = "http://api.meta.audio.stackexchange.com",
                    SiteUrl = "http://meta.audio.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for recording enthusiasts and professionals, audio engineers, producers, music composers and arrangers",
                    IconUrl = "http://sstatic.net/audiometa/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site GraphicDesign
        {
            get
            {
                return new Site
                {
                    Name = "Graphic Design",
                    LogoUrl = "http://sstatic.net/graphicdesign/img/logo.png",
                    ApiEndpoint = "http://api.graphicdesign.stackexchange.com",
                    SiteUrl = "http://graphicdesign.stackexchange.com",
                    Description = "Q&A for professional graphic designers and non-designers trying to do their own graphic design",
                    IconUrl = "http://sstatic.net/graphicdesign/img/apple-touch-icon.png",
					State = SiteState.Open_Beta
                };
            }
        }

		public static Site GraphicDesignMeta
        {
            get
            {
                return new Site
                {
                    Name = "Graphic Design Meta",
                    LogoUrl = "http://sstatic.net/graphicdesignmeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.graphicdesign.stackexchange.com",
                    SiteUrl = "http://meta.graphicdesign.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for professional graphic designers and non-designers trying to do their own graphic design",
                    IconUrl = "http://sstatic.net/graphicdesignmeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site Atheism
        {
            get
            {
                return new Site
                {
                    Name = "Atheism",
                    LogoUrl = "http://sstatic.net/atheism/img/logo.png",
                    ApiEndpoint = "http://api.atheism.stackexchange.com",
                    SiteUrl = "http://atheism.stackexchange.com",
                    Description = "Q&A for people who do not believe that deities exist",
                    IconUrl = "http://sstatic.net/atheism/img/apple-touch-icon.png",
					State = SiteState.Open_Beta
                };
            }
        }

		public static Site AtheismMeta
        {
            get
            {
                return new Site
                {
                    Name = "Atheism Meta",
                    LogoUrl = "http://sstatic.net/atheismmeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.atheism.stackexchange.com",
                    SiteUrl = "http://meta.atheism.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for people who do not believe that deities exist",
                    IconUrl = "http://sstatic.net/atheismmeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site DatabaseAdministrators
        {
            get
            {
                return new Site
                {
                    Name = "Database Administrators",
                    LogoUrl = "http://sstatic.net/dba/img/logo.png",
                    ApiEndpoint = "http://api.dba.stackexchange.com",
                    SiteUrl = "http://dba.stackexchange.com",
                    Description = "Q&A for database professionals who wish to improve their database skills and learn from others in the community",
                    IconUrl = "http://sstatic.net/dba/img/apple-touch-icon.png",
					State = SiteState.Open_Beta
                };
            }
        }

		public static Site DatabaseAdministratorsMeta
        {
            get
            {
                return new Site
                {
                    Name = "Database Administrators Meta",
                    LogoUrl = "http://sstatic.net/dbameta/img/logo.png",
                    ApiEndpoint = "http://api.meta.dba.stackexchange.com",
                    SiteUrl = "http://meta.dba.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for database professionals who wish to improve their database skills and learn from others in the community",
                    IconUrl = "http://sstatic.net/dbameta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site ScienceFictionandFantasy
        {
            get
            {
                return new Site
                {
                    Name = "Science Fiction and Fantasy",
                    LogoUrl = "http://sstatic.net/scifi/img/logo.png",
                    ApiEndpoint = "http://api.scifi.stackexchange.com",
                    SiteUrl = "http://scifi.stackexchange.com",
                    Description = "Q&A for science fiction and fantasy enthusiasts",
                    IconUrl = "http://sstatic.net/scifi/img/apple-touch-icon.png",
					State = SiteState.Open_Beta
                };
            }
        }

		public static Site ScienceFictionandFantasyMeta
        {
            get
            {
                return new Site
                {
                    Name = "Science Fiction and Fantasy Meta",
                    LogoUrl = "http://sstatic.net/scifimeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.scifi.stackexchange.com",
                    SiteUrl = "http://meta.scifi.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for science fiction and fantasy enthusiasts",
                    IconUrl = "http://sstatic.net/scifimeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site Guitars
        {
            get
            {
                return new Site
                {
                    Name = "Guitars",
                    LogoUrl = "http://sstatic.net/guitars/img/logo.png",
                    ApiEndpoint = "http://api.guitars.stackexchange.com",
                    SiteUrl = "http://guitars.stackexchange.com",
                    Description = "Q&A for guitar players and musicians",
                    IconUrl = "http://sstatic.net/guitars/img/apple-touch-icon.png",
					State = SiteState.Open_Beta
                };
            }
        }

		public static Site GuitarsMeta
        {
            get
            {
                return new Site
                {
                    Name = "Guitars Meta",
                    LogoUrl = "http://sstatic.net/guitarsmeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.guitars.stackexchange.com",
                    SiteUrl = "http://meta.guitars.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for guitar players and musicians",
                    IconUrl = "http://sstatic.net/guitarsmeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site CodeReview
        {
            get
            {
                return new Site
                {
                    Name = "Code Review",
                    LogoUrl = "http://sstatic.net/codereview/img/logo.png",
                    ApiEndpoint = "http://api.codereview.stackexchange.com",
                    SiteUrl = "http://codereview.stackexchange.com",
                    Description = "Q&A for peer programmer code reviews",
                    IconUrl = "http://sstatic.net/codereview/img/apple-touch-icon.png",
					State = SiteState.Open_Beta
                };
            }
        }

		public static Site CodeReviewMeta
        {
            get
            {
                return new Site
                {
                    Name = "Code Review Meta",
                    LogoUrl = "http://sstatic.net/codereviewmeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.codereview.stackexchange.com",
                    SiteUrl = "http://meta.codereview.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for peer programmer code reviews",
                    IconUrl = "http://sstatic.net/codereviewmeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site CodeGolf
        {
            get
            {
                return new Site
                {
                    Name = "Code Golf",
                    LogoUrl = "http://sstatic.net/codegolf/img/logo.png",
                    ApiEndpoint = "http://api.codegolf.stackexchange.com",
                    SiteUrl = "http://codegolf.stackexchange.com",
                    Description = "Q&A for code golfers and programming puzzle enthusiasts",
                    IconUrl = "http://sstatic.net/codegolf/img/apple-touch-icon.png",
					State = SiteState.Open_Beta
                };
            }
        }

		public static Site CodeGolfMeta
        {
            get
            {
                return new Site
                {
                    Name = "Code Golf Meta",
                    LogoUrl = "http://sstatic.net/codegolfmeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.codegolf.stackexchange.com",
                    SiteUrl = "http://meta.codegolf.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for code golfers and programming puzzle enthusiasts",
                    IconUrl = "http://sstatic.net/codegolfmeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site QuantitativeFinance
        {
            get
            {
                return new Site
                {
                    Name = "Quantitative Finance",
                    LogoUrl = "http://sstatic.net/quant/img/logo.png",
                    ApiEndpoint = "http://api.quant.stackexchange.com",
                    SiteUrl = "http://quant.stackexchange.com",
                    Description = "Q&A for finance professionals and academics",
                    IconUrl = "http://sstatic.net/quant/img/apple-touch-icon.png",
					State = SiteState.Open_Beta
                };
            }
        }

		public static Site QuantitativeFinanceMeta
        {
            get
            {
                return new Site
                {
                    Name = "Quantitative Finance Meta",
                    LogoUrl = "http://sstatic.net/quantmeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.quant.stackexchange.com",
                    SiteUrl = "http://meta.quant.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for finance professionals and academics",
                    IconUrl = "http://sstatic.net/quantmeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site ProjectManagement
        {
            get
            {
                return new Site
                {
                    Name = "Project Management",
                    LogoUrl = "http://sstatic.net/pm/img/logo.png",
                    ApiEndpoint = "http://api.pm.stackexchange.com",
                    SiteUrl = "http://pm.stackexchange.com",
                    Description = "Q&A for project managers",
                    IconUrl = "http://sstatic.net/pm/img/apple-touch-icon.png",
					State = SiteState.Open_Beta
                };
            }
        }

		public static Site ProjectManagementMeta
        {
            get
            {
                return new Site
                {
                    Name = "Project Management Meta",
                    LogoUrl = "http://sstatic.net/pmmeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.pm.stackexchange.com",
                    SiteUrl = "http://meta.pm.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for project managers",
                    IconUrl = "http://sstatic.net/pmmeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

		public static Site Skeptics
        {
            get
            {
                return new Site
                {
                    Name = "Skeptics",
                    LogoUrl = "http://sstatic.net/skeptics/img/logo.png",
                    ApiEndpoint = "http://api.skeptics.stackexchange.com",
                    SiteUrl = "http://skeptics.stackexchange.com",
                    Description = "Q&A for skeptics",
                    IconUrl = "http://sstatic.net/skeptics/img/apple-touch-icon.png",
					State = SiteState.Closed_Beta
                };
            }
        }

		public static Site SkepticsMeta
        {
            get
            {
                return new Site
                {
                    Name = "Skeptics Meta",
                    LogoUrl = "http://sstatic.net/skepticsmeta/img/logo.png",
                    ApiEndpoint = "http://api.meta.skeptics.stackexchange.com",
                    SiteUrl = "http://meta.skeptics.stackexchange.com",
                    Description = "Q&A about the Stack Exchange site for skeptics",
                    IconUrl = "http://sstatic.net/skepticsmeta/img/apple-touch-icon.png",
					State = SiteState.Linked_Meta
                };
            }
        }

    }
}