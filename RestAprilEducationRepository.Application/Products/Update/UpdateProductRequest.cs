using System;
using System.Collections.Generic;
using System.Text;

namespace RestAprilEducationRepository.Application.Products.Update
{
    public record UpdateProductRequest(string Name, decimal Price);
}
