using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Информационная_система_проектной_организации.CustomElements
{
    public static class Animator
    {
        public static List<Animation> AnimationList = new List<Animation>();

        public static int Count()
        {
            return AnimationList.Count;
        }

        private static Thread AnimatorThread;
        private static double Interval;
        public static void Start()
        {
            Interval = 12;
            try
            {

                AnimatorThread = new Thread(AnimationInvoker)
                {
                    IsBackground = true,
                    Name = "UI Animation"
                };
                AnimatorThread.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static void AnimationInvoker()
        {
            while(true)
            {
                try
                {
                    AnimationList.RemoveAll(a => a.Status == Animation.AnimStatus.Completed);
                    Parallel.For(0, Count(), index =>
                    {
                        AnimationList[index].UpdateFrame();
                    });
                    Thread.Sleep((int)Interval); 
                }
                catch(Exception ex)
                {
                    //MessageBox.Show("ХВАТИТ ТАК МНОГО КЛИКАТЬ!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static void Request(Animation anim, bool RequestIfExist)
        {
            anim.Status = Animation.AnimStatus.Requested;
            try
            {
                Animation dupAnim = GetDuplicate(anim);
                if (dupAnim != null)
                {
                    if (RequestIfExist == true)
                    {
                        dupAnim.Status = Animation.AnimStatus.Completed;
                    }
                    else return;
                }
                AnimationList.Add(anim);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static Animation GetDuplicate(Animation anim)
        {
            return AnimationList.Find(a => a.ID == anim.ID);
        }

    }
}
