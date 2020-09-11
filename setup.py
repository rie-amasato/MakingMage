import setuptools

setuptools.setup(
    name="MakingMage",
    version="0.1.6",
    author="Yumi-Amahane",
    description="Making Mage Program",
    url="https://github.com/Yumi-Amahane/MakingMage",
    packages=setuptools.find_packages(),
    entry_points = {
        'console_scripts':['MakingMage = MakingMage.MakingMage:MakingMage']
    },
)
