using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace mp4Utl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            { 
            MessageBoxResult Result = MessageBox.Show("�㏑���ۑ��ͤ������ƍς܂��܂�����?\r\n���ۑ����Ă��Ăं��Ă��Ȃ��ĂऍŏI�`�F�b�N���ʂ����Ă͂����܂���!!", "�m�F", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if(Result == MessageBoxResult.Yes) 
                {
                    MessageBox.Show("�łͤ�܂����̂��y���݂ɑ҂��Ă܂���!\r\n�c�c�ւ񂽂��ӂ��񂵂Ⴓ���", "�m�F");
                    this.Close();
                } else if(Result == MessageBoxResult.No)
                {
                    MessageBox.Show("�܂����������c\r\n���܂߂ȕۑ��ͤ�ƂĂ��厖�ł�!!\r\n��`���̂ɖ����Ă����Ă���������!!!!", "�m�F");
                }
            }

        }
    

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("�o�[�W�����F��4\r\n��ҁF����ݔ��H\r\n\r\n���̃\�t�g�E�F�A�� [CC BY-NC-SA 4.0] ���C�Z���X�Ɋ�Â��z�z����Ă��܂�����Ԃ��");
        }
    }
}
