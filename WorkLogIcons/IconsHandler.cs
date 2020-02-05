using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WorkLogIcons
{
    public class IconsHandler
    {
        private Icons icons = new Icons();
        public Image GetIcon(IconNames iconName)
        {
            switch (iconName)
            {
                case IconNames.Back:
                    return ConvertBase46ToPng(icons.Back);
                case IconNames.Save:
                    return ConvertBase46ToPng(icons.Save);
                case IconNames.Analyser:
                    return ConvertBase46ToPng(icons.Analyser);
                case IconNames.Manufacturer:
                    return ConvertBase46ToPng(icons.Manufacturer);
                case IconNames.Institution:
                    return ConvertBase46ToPng(icons.Institution);
                case IconNames.Error:
                    return ConvertBase46ToPng(icons.Error);
                case IconNames.Search:
                    return ConvertBase46ToPng(icons.Search);
                case IconNames.Logout:
                    return ConvertBase46ToPng(icons.Logout);

                default:
                    break;
            }
            throw new NotImplementedException();
        }

        private Image ConvertBase46ToPng(string base64String)
        {
            byte[] ImageData = Convert.FromBase64String(base64String);

            using (var stream = new MemoryStream(ImageData, 0, ImageData.Length))
            {
                return Image.FromStream(stream);
            }
        }
    }

    public enum IconNames
    {
        Back,
        Save,
        Analyser,
        Manufacturer,
        Institution,
        Error,
        Search,
        Logout
    }

    public class Icons
    {
        private readonly string _search= @"iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABmJLR0QA/wD/AP+gvaeTAAAC4klEQVRIDa1V30sUURQ+57rKzq60u7r+QKggjCjoqafAxHwNetIe8qlfSqQGuZV/QWDtbqgQJVIPUVQPEUFPQaXVH5APRQQGCSK6um7ojuk6p++OY+m6sw7Zcr757j3nu+fMuTtzh4k2/8Lh22H5ZZ1n4hOI1BNJkIgXwd/Ar9i/PJxO92YQ82S8URXxx9uEqR+JKjf688YpFO9Km1ee5PkLTtW6N2LEe4X5oZN8RIhaVn1SJWXLFTaTtEI7CkSF5HHIiF/DeFuzOwgZiVYMnkKdE5bOTDY2hHFBiwQSF0VoAMESbFvLvBl7jrGrcQUN7LKMFewvVSP5BSQfdlU7gVAg0cFCd9HlVJnp3z9Dlxac0BZSSH4W3mpgxEty6CiT7bkH/oCua1cM8wzGrqYQOQmQEN/R7BVMsqZnste7rVNo86AOljK/1+wVitSorRU+ZLPLRTFRhY6lsplZzV4xa/pSjrbYI026gzktjAZCRYVasxGVRi7qzIvemO7gixauiBzT7BUWWY22luWzzS4XBf9LgPCndWn2BmGLaE0vZK93W6eUWXofwWmgIWIkO8HbWthIdOO4OIoHZKrUNB4UW6DmqPunEOnEeEElGQrE24st0G8yjpO4o0kUe8m0Bg+RJiL7LCK+gZn2jeAOh0Ssj/NLCxNhf/luOBtwVrUj3gg4JrOspDm9eHXMcWwhrPvrwxadxkGWhKcGKGjodkqJDKJYDIIIMEMiPaSoXgkPz5k9E/D9sU0FtLeGbgWXAtzGwqcwPwxUA9PEMoa3/VkwW/5okjqy2Moj0LxGTBcB2fadydeUNi//sGe4bCkAn2cL+ZPnmCX/cBxHkePrRZTnbAWE2P+9Bdz7hHJvI0b/Hh3bUQdVwZu1OUu9w9Yd0MnyMI67b9pRAZ0wGuirW5WSNy5FPqGIlv07UtnrkyW82oyT4GuBLJEdd7CetFAnwtT+3wroQrpITnwvMK7D97oP3+vB30kJ7396vS1sAAAAAElFTkSuQmCC";
        private string _back16px = @"iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAABmJLR0QA/wD/AP+gvaeTAAABCElEQVQ4Ed2QPUsDQRCGn90TlMQNVyhYprazEMFGsFRshfwJf4OQHxIrFw5bK7ESW2vFyg+MYHmHKLo3TrImniZEwUYc3rmZd75uZuEPS5aQdtLvFrRjC+rZAi4cE6ZPx+YrwdEBNb+EDWdaswamrnYizKes86vadAgyWL2LLbcok5wgBY8X97BbVns+BjT8CiJHOsBVC774L8pvEToUrbb6xAFufw7sZeXPvdwkvSJvNVGJb5CnuTafK/8ptD6WTkWz8YzJNpHXEz1hMcaG3yf1uqp3GLlB7DVi9J00oognqNPHbDaPCb3kcp/DcNV3PmLiCYNwsf3ATLKu9ED1l2j4HZzf4//LG5s9QZvZOQSXAAAAAElFTkSuQmCC";
        private string _save16px = @"iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABmJLR0QA/wD/AP+gvaeTAAACRklEQVRIDe1UQUgUURj+3sxkazV7LeikQlKQ0K1jeLS8yq4QqSxol7qVdLEuYXQLq4OGZNmG16BLRF0TQlAiFiK6ZEYnHXfLdWZe37zZ2ZnZWXN28djj/99873v/+/597/37gP9tnxMQsXnz5SVAPiDXRW/FJmHl7zVboMVIIR9x3Ko4l2AaZvGmBxpdxAizKNXYysd5RTbpgvhwKrGT+A7CwHbRNLLF24i0g07AK8RURB8HnyCqTmzQk5Y822RMSqZ5gnSLPzPsKTTxBra2DgEHsnoCunYBkdZOgj8QYhJb2gww5ES0PPiL3Rq9bq0m+A0Xgyjn3gJLHTj2osBkBar10D37Aog5WJvzwPiuR8Trfe+zr7I8bsE1FlEe2kDn0knoziseyzlPJOniI5zdQVQu/0iZQNyAlbvvC81nYGY+EPfR9zaJFWzr59OVqesu1JWymavE/xJ/xvlvandZZ0LjYH9zDaMeJDFcx8BOBHtwlju9Ak3vh0SFPpwuge6OIGyna/ATC7Obv/ShGkvMUHwceK9D2nfJH+G9nUmXQMgpHF84qoS4Sn0lVlEpbWCrdA0QY9guXQfuCJg/H0OKnIqBkI0JvvsTif4Qyh1dNdavc4E8zN4nirNyLEsis3eW+QtEga01JBATnFmnJ02T/YqUWFRfvxvxk7wzYJ6aIzVGD03iuQhHadHrwzA3lxndRw/sK0E3PbSWyjRcRjSwA1sfYIWscBBYXBz8o7n2RT4l1TZ2EGh6T4U9WnsqztbYVV547Kn4CwuwnKZ+KjrrAAAAAElFTkSuQmCC";
        private string _analyser16px = @"iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAABmJLR0QA/wD/AP+gvaeTAAABmElEQVQ4EbVRTStEURh+zjlMzYx7xUbJhohRUoyPnaUsZEFToyhb2VlYWVD+glKj5KMZ8wMUUzb4A8hOYqGmhjBjhpq513OGmbpm7li5ved93s/nvuc9Avjr26qHaS6xqgtv4UWiQ6TDq3DiXpjGEWw7zVQzGmIBokNqExiFDVgigvRsBDYSENawo5uOO0HLrp/5IDLhQyJFWICsqK8IwIyuwxdtRba+H7Av2FmSEfrd8O/3lQIanQTe/TaOugqFPSYVhMgTATPeyT3M0V6BVJcwY3qpdDlTUZdUzvNEM8kTgPq4IlmQxaOwC8cQ8DGu5ROWPNWGPs4JEMpxaeP82xpeFl7YdEtbX6NDF/M884SRCd0QiyKK+rfSC0zOv6PxoInXGENBdpHsGh7vOVJT+knLHdUJjOgOG05gwSROcHmdMIwhPE5my50/hvpBJ3hm9PiD/Hs797ANKbJITSecRd+e/AYXbdu9LplyuDZBuczd+CcCpe559z4U8svcwwDtB7cZZNXEa+gOwj6DqtvkC/Qg/bZXtY7BL9A7ZzL8ewYfAAAAAElFTkSuQmCC";
        private string _manufacturer16px = @"iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAABmJLR0QA/wD/AP+gvaeTAAABdElEQVQ4EZVRPUsDQRB9c3cmBnNJxEAUxFps/QX6K8RKEKxtrQQF7SwstPcjCZImja2NWlkJgq3YKIIIihpzyfjWi8muhMgd83hz87VvdgVI8I2e5NFsXUMwBegZXhfnvQTtQBTNxM2mS+aA03SyAepNmNYusm+5ZAOg7gCvWQi60wY5xXqIxkuK8ktQq1C8vKsgLE8jrNaQrS78lIXlInKVDTTe74ChFai4CiLkYwWZo0kEwTpvdokI4OkNwsoOADZhhEwTYW6cTs9EC8LCLUZWiQwxyM4BYY3OWkXLZoU1BpjAIfmJ4EHYJUdEAyJ7ZGNpJv4ogH0Hus8THkwlRDfJHCAfaEbb9NkLn1wiLFP7FaTGqmKclStymv8p+P4Ffc7GGDkgetZ2FFgrQOIVFJ98ut8VXPlmjIizQp3HPJs40D4gt7j/F6LWMX1jVGTIhjgrXFJyJyvxZUKHEfj3nWAfatsK+uT/C2ms4JZ1KSK5CR6/AQX6WomfyqfrAAAAAElFTkSuQmCC";
        private string _institution16px = @"iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAABmJLR0QA/wD/AP+gvaeTAAACDElEQVQ4EY1SPWsUURQ9d+bt7sxElGzjPzCFlRII2inYiBLBj8JCCIoR0VJQEDI7IAYsbAKaImBj41Y2Fgo2QaysgqgQEPwilWH92MnsfFzP22RwshPB5d537ztzzt1373sC7PzzG9EUVBcB+SxZMdtH+G0nplMHQ883nXmKl+mvAPXVyFvPjS7UuSxfBT3TOSKKJQgSiM4009aHHtq/fHftFLGHArzRTC/FCD+VOmczuTfmueEiCc9JfBJnwSRrTw3M4CPF7wrRnpPpfgX6YmQlaESXeTLSyQoa4WSh8oj/PKaiFx3BD1Vh7zi4WXxrFXSd1FzXRnZGFfOUvpTMveKQ/JS9Lse5f4glp7l/Tcl2MQEozhYme89TmMLVA4R2s9h9agDPhEcF8oDgPnppX9iOLcbT4iRBjz40il7krl5NknBVfLdzmsQuvxDnWhqPHKdz5+yWt7LGuJdetRiZO+GIgzbR7WIC/2F+0dJg6xb+0jnME82s2Y7TYKZEvaw1YTEB7pRYGU2ZlJFX9rOHW+vl3sZ13OzZ6CHaEE7T5qXXCohglj0f51WtbORzjy3RM9FtCndxmoftvuq1AlA5bwmcTRc5hgUovkZsdIiEgHqBIcxF0dyDu+PMMMCgNiuLWzeFYpXDsfmoT/Mpfx8FK/vfSZJ/HWrZ8w0mx/g8GSqUf6QFNOUTXujn4bM/SWGxXbQVNaQAAAAASUVORK5CYII=";
        private string _error16px = @"iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAABmJLR0QA/wD/AP+gvaeTAAABoUlEQVQ4EZVSPUscURQ9d+7bWfyARC0EQVT8SPyIpSAomjpWYrNa2otFIF32KcEiEDtBsbHPn7CwsBQsbew0pBRB3DfzPDu7M87irLCXc/bdr3f2vvcGeMdsGM7/AobfaUHQrrinWpE4voqMuabQ53Z9hQIHwABEjrhJyA8UOvVA3WfYikKBmmqVbX1kiqV91fU0yK9vVG25PCVRdM0mLyK7sffjbPrO+MY7N2eBZ+TszQRBFP1hPSQvf9Zqx3DuB/2InAyM2eHaghYBXtw3D6wlHSJjyQoMcVUSrFVtI0ZqmYAFDC/uN1LzftgC3TBmAq/WK6oWOcsEmuPN5GqCMJzgPXzK5fgWsm1LpYU0l4xmgX4EwV8AXWQGPp8TYJGJSTKFMDd1HsdnoDUmUN2j30/m4Xikf3yF+3yy6a9Y1Y26L/thOOv5xTEwZB4XVeeWT4DSvTFPLDT+jE4C7299FE3rahDUv7gvSbL1Z/Cr6uODyCbvITtz1iLyMVC9M/B+FMVWZu2Qm4urzPJ4I4YqFY6yxTfuZq4T/O9x7riTDYW9L1FOZ8uu8IrtAAAAAElFTkSuQmCC";
        private string _logout = @"iVBORw0KGgoAAAANSUhEUgAAABoAAAAaCAYAAACpSkzOAAAABmJLR0QA/wD/AP+gvaeTAAAD3klEQVRIDa1VTWhcVRQ+584kb2bSZF7UIlHiDypoqGARV+4FXRjjD678QZAiFGR+koql0Cgo2sxUF4K6KCKitNqmoht33bkSdFFcqOBPrT+JmZnazpvnzLun37kzeZmkb4ZofJxz73fOufd89+/dy0TDv2tyR6cikjkimbVE0yy0W3sI04qx9DMZ+jTN0fLKpYXf1T9IeVBgwqvemjLyihA9gjYGOkwsEp2MLL94ISx+n9QQ8SvdfnbpYSJ+H5ExaAj9GDNaFkl9TV6rBpsozEwS271IgNnSo/B50IvE8kS9WT4NvEnQbpNNICmApAIvYvwJCc/XW4UfaciXzxy5mTm1hMFggIQVlmI9KL/Z3wXJNkw/V50lkVPwYMWktLUx/EOlN8gjaMTMNFtrlj4HdhITXZ2tXo9N/xbecShISlXU/1ry2eo8k7yOjo00mztWm4XfgHFmtIRGbF9GpSSn68F/I0F/agQFLCHpTPKRtYvqUzVa+JmlG7EXTwL/IzYqo96BsFgbFZGgjV/gmauylWng3oyYZ2GkhORUI1z4AXhHciFc+I6J9OSlQPagJnMzEqH71cBp02AX7rhkl8taekBTOSIckVvUEMtfaf1/aMcal8uwuNzpblKZ0toLvaHXyORY9U6x8gXaGkNmbi0ofAmcKF4Ynu9k0yTE12kDNyP8NI5whaK2Ogcpdvk2xKag11qR21EPlAyNdHpBl9sRMfGqOv1MpEkUJquwHwfYTsQ4AfztddxMEPoT2jt1RN+oIWzv1nqgsuTjmJjxGCcAY9L39Nwut5sRjvUZwocjOYdqsDDHRMwylAhL+1Q3kZwhfI4oRXQcOII+5meO3kSDPqGYyBINJNInBnfdfUjTwVulubtLtxaUfiGm94hoFFf/B0QnwA1ri+DRG1t3IVF2HW+u3xkxRj6EDyebj602D5wH7hI5IJ3DRNSA3utnzh1EfYXgddsgEkok8nMXD6Gj7k/dML0E7MS4EsVacOAcbt3nAHH0ZRG38Kt4X7Bt8PQERkwktJVIeDJbeQ0/jhLhsuF9fwXFX3tdN2akjlpQ/gjJnwfG4OUFvE93AW8IUy42eDNRPvfGXpAvIG5x0+xvBMUTwLFgkDGOgZ9begi3+TEvsNN/0PwlP1c5i5HOxA36gdDZequ0Zze9taudbf3EzE/XmsXP+psojpdOjXXVN3/ERDPBRMpTnwgvap2kuJ1dLJwIR9smNZNEov1Yi+3oZKbyLpI+299WRN5utMq6r/3uRJw4o6SWtda0Jlzui51stG7Y32cPhdueUTfL4VE/O34cWOrBrseJ9rWBtyWXARX3O21eeMj5AAAAAElFTkSuQmCC";
        public string Back { get => _back16px; }
        public string Save { get => _save16px; }
        public string Analyser { get => _analyser16px; }
        public string Manufacturer { get => _manufacturer16px; }
        public string Institution { get => _institution16px; }
        public string Error { get => _error16px; }
        public string Search { get => _search; }

        public string Logout { get => _logout; }

    }

}
