import setuptools

setuptools.setup(
    name="MakingMage",
    version="0.1.0",
    author="Yumi-Amahane",
    description="Making Mage Program",
    long_description=long_description,
    long_description_content_type="text/markdown",
    url="https://github.com/Yumi-Amahane/MakingMage",
    packages=setuptools.find_packages(),
    classifiers=[
        "Programming Language :: Python :: 3",
        "License :: OSI Approved :: MIT License",
        "Operating System :: OS Independent",
    ],
    entry_points = {
        'console_scripts': ['MakingMage = MakingMage.MakingMage:main']
    },
    python_requires='>=3.8.5',
)
