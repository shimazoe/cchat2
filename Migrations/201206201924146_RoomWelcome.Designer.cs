// <auto-generated />
namespace JabbR.Models.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;

    public sealed partial class RoomWelcome : IMigrationMetadata
    {
        string IMigrationMetadata.Id
        {
            get { return "201206201924146_RoomWelcome"; }
        }

        string IMigrationMetadata.Source
        {
            get { return null; }
        }

        string IMigrationMetadata.Target
        {
            get { return "H4sIAAAAAAAEAOy9B2AcSZYlJi9tynt/SvVK1+B0oQiAYBMk2JBAEOzBiM3mkuwdaUcjKasqgcplVmVdZhZAzO2dvPfee++999577733ujudTif33/8/XGZkAWz2zkrayZ4hgKrIHz9+fB8/Iv7Hv/cffPx7vFuU6WVeN0W1/Oyj3fHOR2m+nFazYnnx2Ufr9nz74KPf4+g3Th6fzhbv0p807fbQjt5cNp99NG/b1aO7d5vpPF9kzXhRTOuqqc7b8bRa3M1m1d29nZ2Du7s7d3MC8RHBStPHr9bLtljk/Af9eVItp/mqXWflF9UsLxv9nL55zVDTF9kib1bZNP/so+9kk8mrsbT7KD0ui4xweJ2X5++J0M5DIPSR7Yo6OyWk2us316ucO/zso5N51p6URb5s/XbU8vfKr4MP6KOXdbXK6/b6VX6ub1Ojj9K74Yt3u2/a9/yXgMJnH50t23t7H6Uv1mWZTUr64Dwrm/yjdPXpo9dtVeef58u8ztp89jJr27ymaTmb5TwEJcWj1ae3o8bDuzt7oMbdbLms2qylOe5h3sHzbGbQfN3WxCwfpc+Kd/nseb68aOcW1S+yd+YT+vWj9KtlQbxFL7X1OveHJn9v7vKrJq+PLzAZP+yen2dNezxti0umrXT+lCj/hnj4y/PzJm8j03TzYG4x1x0gL7LL4oLnJwLuo/RVXvKXzbxYiVCMHQv//tLmWV0tXlXoovPV7/+6WtdT6vNNFf/+TVZfYKQ+To/vOqG5UZQYgR8J0gcKEnXzgeyMf9+z0w+XoW9nzfyH3unrrPzhawuMFLzUNFdV/b6z++Hdb1JWN2uYCLAX69lFbscRA3UbtF6TOKyb99R3Xcat2vdl3A+XluPztz8n/Z411LPp9UlFKjlbvjfFnpXZxfti/qF4W935Xt1+OOOfLrKi/KH3StM0WxTL956oQVNOzvAyn5I1EtvbfKhZN2Z7yKwbs39b/L68WuazV1W1GMYM3/7+aFc3"
                       + "Xcy8r6KY+d+/L2a3QAojjuPE3wyjJF+/L0bHZVld3Ypa2nIYP7/BMJpBqxi27+WwAeSPHLafNZP4NfywDzcrJ2XVONRvra46UN5Uq2L6nrgffCjq381LmrofPsle1sVl5jyAr0uzsyW5ZPkJobFxBIKRN4BPPxD9kzrPSGo2yVcUzE1aTXXVN6fVYgHosO67LbY6/M2I2kYRHPW7YfRMg/fFzFjID7Oig2h1rOxtsfoib5rsIh/GSxv8/mwdOoj530WtVNDgfc3pLTjuJgM/SK1h5novk6nj+5HV7Hu17c9F6u690ysf3uV357kNBz4wSwjOfG+9HRGaKIyvpftF6D9UM8SkMKo6bovWxvyngRyLlPzvNqL13inQ46appgXj03GpQ7MYjvB0OUtvZSOFp33dR2y8LttiVRZTQuezj77VI99NwK3CDoEL3TYCf3zXG+4tqWBs7o049gzwNzT2rt2+xbB3xuPdHmhS4XkNTZqVpOaats6KZdvX98VyWqyy8gYsOu/d1lJgCmwX3W+e5qt8CV1/A2Vv07fvTfZRsD11zNhNJPo6/KOu0Y3T3PWTviHu6SYxbmaeD5OZQLluwi6uaUP0jJvyngOPu3c3E/SbFZsYFrdh3W9CbGLEvU3f1pL/nMlMYAW5uX0hPsmhSfxG+SdMTN4sOT87/ONjcZs5/Cb5xyfubfq2XtzPGf944dWNuvFnx1f5ITspfn59E27RNfQQOWnyvoOOZvFvHvVul6Eef7l8mpd5m6dYF6wo8DvJmmmGPFQ33CQEviEhiyB/Gz7/JmQsMiG36fqHKWISMiAopjfyWjH4TjaZ1Bwpv+tQS194nbeGQc3ikAs+IvzWY68QiCZLoiCEs24AALEcAiBifgMAl2yKwrBmpgPGo6pHEqMnwqyj13ZjerI76beNxOyQLDl6/HPbuMsDpch35TMc+PsQxWY4N9AjGpHF8e/GZF+PCt0I7GeTACaTumH8sYgijngnpvh6o+9E"
                       + "ED9Lgw+TMvHRD8cWPcyj0YWHupPoG0gQjSVuIuQH0kCU2mYa9O39IOqByf8QGgQm/meJDzz/bZMM3FoZfhNa8Iei/nw/bmDkg65eD+2Ys+fhbc3yDaOPuXYfMHyTg7QOhf3u8d3XnMnXDx7fpSbTfNWus/ILynCXjfnii2y1ovy4+dt9kr5eZVOgvf1a1wlut0hwcJfWCRYC4+40YKmu+2N7IltA4tD5lromTJ8VddNSOj2bZMibn8wWvWa3cZ9MV6EX1Z8s44yY9vjdOWmvxkI839nqwHAEfEZjWlALHp4OTphlw8v0+utpVmZ1bL3npCrXi+UGh3n4fayHyOvu79u/Db48vgDCARDv49vDep41LeIRWhTvDCn85vYQrQPfxe33HyDS47udKerygZfa15Ydiezy1a24bkjFvgfPxTTVLTku/ur/O/kN/4bvyye3h/DtrJmHEOST20N4nZUddpdPbg8BPWLVtWmuqrpDj+53t4f6zcsP3nuxnl3kHRz9z28P7TUtDK+bDuX0s9tDeVG1XQ7gT24P4fj8bR+I/fD2cM4aeqnDzPLR7WE8K7OLEIR8cnsIbsk+lCrz6e0hnS6yogzB6Ee3h0EEmC2KZY8q8uH/axSueKQfpHBjkdEtFW781Z8thfvNCjH+/TAFfFJWTRcX89ntobypVsU0BKIf3R7Gd/OS3NPOcOyHt4dDucjLrKtQ7Ie3h3O2JAWdw7ftyI/3+e2h+euyAa01xfL/LhfIRsgfJJQmPfj15HLw7Z8t0eTQpOs72w9vD+fDfKrvzvOOwpZPbg8BCq1HC47n35Mg/69z2MMAuxMrmqRFmF6+wWZ0Wg/ZhyHHHGmDLhfFIA+vc9yOky3QgQUQD42vi+GboUWg22M4zBrDGHazJl9/3k0C+aYZN+1umuv+Ot0GUoYJ5w8hopvm2xPxVrj9f36CbynRtxTlvfeZ3v8XC/H/y6W3l/rsNrE2Qz+xf9vUp6YdZZ7de5I45RE1"
                       + "mgLt5iGlyUcp4X5ZzJCDfH3dtPlijAbj17+oNAuxpsEX2bI4z5v2TfU2pwQ00qSUky6LrJFs9HtlWB/e3dm7m88Wd5tmVkbyq2BkbzZjqcbHNB/dyTATsXFR/vHd7pv2Pf8lWc8tQAKWl89zmiHykynj0bZ5vfRD1xfrsswmyJCfZ2XTc3678OH1CPjlZVZP51m9tcje3fHhtPX6RjBe7vIbgBamXgTgjMbbFou8Oj9vSITed5xObDxiboThe0E3ckXf6/j/FU98lH6RvXueLy/aOYvb+04o/v1GOEPSjt8AoNecffwGAHVTj98AyE3s/96T6WcshkHdBi2TdrytAEXYgJOF3yxr2RzkNwtWk5ICdFK8/1glJbkJqfdGycrzN8BjmqT8BiDZROVtafVeirWf9vv/sGL95mQxplA/lOVNPvG289iHoMnEDWgdvDdWNrX4zQ7WZhq//mj9DKMi18Ps0/fFK0g0RjVtH8p7CVQ0X/f/YZmymb9vQpV9M/ZbMoGhgH9Nt9UForfkhT6IGzzfD2Sn4bTb7Xjqhmg7/sJQDHwzN4bdfX1PJsTitnC+NmU7Sa4fkfabI20nwfQj0t6atF5OyYMv+RHOd3UoS9mp9FVVengYHJCzGbsPv1iXbbEqiyl1+tlH/QTvl8uneZm3eYogqSLjcZI102zWHz4SYptwMHmlDhbm4xCPb/XA0/TmNcxWVpIVatqaMme9tRRyNJbTYpWV3bF3GkbZJs5edy3M7jdP81W+hCXtD/I23W3KLVrQHRLfRIQg93gz+zCbqxP0zfDPzni825u6EBYHGV1Y8uH/P3igH0Vx04ie2rTO/UNjAvVRf/9I8Pc1J+4WTGAc4y44+/nPGivcena+CVYYXu3v97dpGcTC/uGwwjdnT/5fzQo/VK3wPqzw/xbTcONy/dfVED+LbkYQI8VwGWLVb5Cxfqg6Zjgo5Ffe25/+ueOw2IJtMLtZe2vF8/9zDrv1ZP+ccdj/W3TY"
                       + "l1fL/49qr92NzLX7s8hdP2f6q0fZQfb6f4sCU/b6/6Dq+rljr1vrkZ879vp/i/b6/6zrtbeRu/Z+Frnr50x5dZKb/M7/u5XX/2fdrp877vo50123564fqu465Ww11gXpjbw2aNA67bOibtqnWZtNsqavu/DW67zt5bI/SuW7gSzx6+k8X2S00jepiAUki+6+byKphn5HwrfRbuSroU5YXG7VhSjeaBfy1VAX+PZ2Xdj0SLQX++1QR9rgdn2FQc3gsG6mYMfDeM+ud2/R9+7tOn//ce/dovO9zbwzPMGecMWEQhJyqdeqJxqRnN2AFrcD9T/saYrwzVA27bvm464mD4dzy6GyRTKLEQNjDdr8bA3WF177pnz4jQw0SLgPDHQ4Kf/10e292VEh9mX7+Tc63E08PJx4/gbn9YczXGbRWOJ0E0vfmGj9Bmc9pswDCEME/cYIog7nrQkSc1C/Qb74OSFImJbaRIoNCayfJa6wdjZKhb7d/nAy3IIjNiRafpZ44YdIhlsrih+6hrBuT5QIe988ETawQrThD4MTvjkiIMoFIBsw2e8e3xXXUT+gP8nHIbP0BYVSZcOfUpi2prcXufz1NG+KCwfiMcFc5hxkO6CmzdnyvDLRYgcj08R8rdPyRd5mM4rejuu2OM+mLX09JUNZLC8+Sn8yK9fU5HQxyWdnyy/X7Wrd0pDzxaQMok7Em5v6f3y3h/PjL1f4q/kmhkBoFjSE/Mvlk3VRzizez7Ky6Zj7IRAIZD/P6XOZS4qL2/zi2kJ6US1vCUjJ99TE32/yxaokYM2Xy9fZZT6M2800DCn2+GmRXdTZolEY7n36k9hvtnh39P8EAAD//wUufCdGewAA"; }
        }
    }
}
