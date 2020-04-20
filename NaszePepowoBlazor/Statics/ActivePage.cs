using NaszePepowoBlazor.Extensions;
using NaszePepowoBlazor.Models.Result;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NaszePepowoBlazor.Statics
{
    public class ActivePage
    {
        public ActivePage()
        {
            _pageNumber = 0;
            CurrentPage = AppPage.Index;
            _synchronized = false;
            _posts = new List<PostResult>();
        }

        public AppPage CurrentPage;

        public int CurrentPagePostsNumber
        {
            get
            {
                return CurrentPagePosts.Count;
            }
        }

        private int _pageNumber;
        public int CurrentPageNumber
        {
            get
            {
                return _pageNumber;
            }
        }

        private bool _synchronized;
        public bool Synchronized
        {
            get
            {
                return _synchronized;
            }

            set
            {
                if (value)
                    _synchronized = true;
            }
        }

        public List<PostResult> CurrentPagePosts
        {
            get
            {
                return CurrentPage switch
                {
                    AppPage.Index => IndexPosts,
                    AppPage.KGW => KgwPosts,
                    _ => null
                };
            }
        }

        private List<PostResult> _posts;
        public List<PostResult> Posts
        {
            get
            {
                return _posts.ToList();
            }

            set
            {
                if (!value.IsNullOrEmpty())
                {
                    _posts.AddRange(value);
                    OnSyncStateEvent?.Invoke();
                }
            }
        }

        public List<PostResult> IndexPosts
        {
            get
            {
                //Bierzemy posty które nie mają etykiet
                return _posts.Where(w => w.labels.IsNullOrEmpty() ? true : (w.labels.Contains("ogłoszenie") || w.labels.Contains("aktualności"))).ToList();
            }
        }

        public List<PostResult> KgwPosts
        {
            get
            {
                return _posts.Where(w => w.labels.IsNullOrEmpty() ? false : w.labels.Contains("kgw")).ToList();
            }
        }

        public List<PostResult> AlertPosts
        {
            get
            {
                return _posts.Where(w => w.labels != null).Where(w => w.labels.Contains("ogłoszenie")).Take(3).ToList();
            }
        }

        public void NavigateToAppPage(AppPage navigateTo)
        {
            //Zmieniamy obecną stronę
            CurrentPage = navigateTo;
            OnPageChangeEvent?.Invoke();
        }

        public bool IsEnabled(AppPage page) => page == CurrentPage;

        public enum AppPage
        {
            Index,
            KGW,
            About
        }

        public event Action OnSyncStateEvent;

        public event Action OnPageChangeEvent;

        public event Action OnPaginationRefreshAsk;

        public event Action<int> OnPageNavigation;

        public void NavigateToPage(int pageNumber)
        {
            _pageNumber = pageNumber;
            OnPageNavigation?.Invoke(pageNumber);
            OnPaginationRefreshAsk?.Invoke();
        }
    }
}
