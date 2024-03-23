from PIL import Image
import os

def folder_exists(folder_path):
    return os.path.exists(folder_path)

def create_folder(folder_path):
    try:
        os.makedirs(folder_path)
        # print(f"Folder '{folder_path}' created successfully.")
    except FileExistsError:
        print(f"Folder '{folder_path}' already exists.")

def get_gif_name(gif_path):
    # Extract the filename without extension from the path
    gif_name_without_extension = os.path.splitext(os.path.basename(gif_path))[0]
    return gif_name_without_extension

def is_gif(gif_path):
    extension = os.path.splitext(os.path.basename(gif_path))[1]
    return extension == ".gif"

def get_files_in_folder(folder_path):
    files = [f for f in os.listdir(folder_path) if os.path.isfile(os.path.join(folder_path, f))]
    return files

def split_gif(gif_path, output_folder):
    # Open the GIF file
    gif = Image.open(gif_path)

    # get frames refresh rate
    frame_durations = gif.info.get('duration')
    if isinstance(frame_durations, int):
        # Convert milliseconds to seconds
        refresh_rate = frame_durations / 1000.0
    else:
        # Calculate the average duration of all frames
        refresh_rate = sum(frame_durations) / len(frame_durations) / 1000.0

    # frames folder
    gif_name = get_gif_name(gif_path)
    frames_folder = f"{output_folder}/{gif_name}"
    
    # Iterate over each frame in the GIF
    for frame_index in range(gif.n_frames):
        # Go to the specific frame
        gif.seek(frame_index)

        # Convert the frame to RGBA if it's not already
        frame = gif.convert("RGBA")
        
        
        if not folder_exists(frames_folder):
            create_folder(frames_folder)

        # Save the frame as a PNG file
        frame.save(f"{frames_folder}/frame_{frame_index:03d}_{refresh_rate}.png", "PNG")

    # Close the GIF file
    gif.close()

    print(f"Extracted {gif_path}")

# Example usage:
gif_path = "gifs"
output_folder = "extracted_gifs"

# get all files
files = get_files_in_folder(gif_path)

os.chdir(gif_path)

# generate frames
for f in files:
    if is_gif(f):
        split_gif(f, output_folder)


