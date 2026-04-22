namespace RestAprilEducationRepository.Application
{
    public class ImageProcess : IImageProcess
    {
        public void Process(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                // 

                throw new Exception("path değeri boş olamaz");
            }

            // Görüntü işleme kodları burada olacak
        }
    }
}
