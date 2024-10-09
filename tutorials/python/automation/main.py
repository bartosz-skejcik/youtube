import os
import shutil
from pathlib import Path


def sort_files(directory):
    extensions_dirs = {
        '.jpg': 'Images',
        '.jpeg': 'Images',
        '.png': 'Images',
        '.gif': 'Images',
        '.pdf': 'Documents',
        '.txt': 'Documents',
        '.doc': 'Documents',
        '.docx': 'Documents',
        '.mp3': 'Audio',
        '.wav': 'Audio',
        '.mp4': 'Video',
        '.avi': 'Video',
        '.zip': 'Archives',
        '.rar': 'Archives',
        '.tar.gz': 'Archives',
        '.conf': 'Configs',
        '.sh': 'Scripts',
        '.ics': 'Images'
    }

    for item in os.scandir(directory):
        if item.is_file():
            file_extension = Path(item.name).suffix.lower()

            if file_extension in extensions_dirs:
                destination_dir = Path(directory) / \
                    extensions_dirs[file_extension]
                destination_dir.mkdir(exist_ok=True)

                shutil.move(item.path, destination_dir / item.name)
                print(f"Przeniesiono {item.name} do: {destination_dir}")


if __name__ == "__main__":
    target_dir = input("Podaj sciezke do posortowania: ")
    sort_files(target_dir)
    print("Sortowanie zakoczono pomyslnie!")
