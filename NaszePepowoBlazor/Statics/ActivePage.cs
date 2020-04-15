using NaszePepowoBlazor.Models.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaszePepowoBlazor.Statics
{
    public class ActivePage
    {
        public ActivePage()
        {
            CurrentPage = AppPage.Index;
            _synchronized = false;
            _posts = new List<PostResult>();
        }

        public AppPage CurrentPage;

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

        private List<PostResult> _posts;
        public List<PostResult> Posts
        {
            get
            {
                return _posts.ToList();
            }

            set
            {
                _posts.AddRange(value);
                OnSyncStateEvent?.Invoke();
            }
        }

        public bool IsEnabled(AppPage page) => page == CurrentPage;

        public enum AppPage
        {
            Index,
            KGW,
            About
        }

        public event Action OnSyncStateEvent;
    }
}
